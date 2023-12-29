using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recruit.Server.Data;
using Recruit.Shared;
using System.Data;
using System.Security.Claims;
using static Azure.Core.HttpHeader;

namespace Recruit.Server.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly ApplicationDbContext tinhCongDbContext;

        public AuthService(UserManager<ApplicationUser> userManager, ITokenService tokenService, ApplicationDbContext tinhCongDbContext)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            this.tinhCongDbContext = tinhCongDbContext;
        }

        public async Task<AuthResult> LoginAsync(string userId, string password)
        {
            var user = await tinhCongDbContext.UserInfo
                .Where(u => u.UserID == userId)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return new AuthResult()
                {
                    Errors = new List<string>() { "Invalid email or password" }
                };
            }

            // Sử dụng LINQ để kiểm tra mật khẩu
            var isValidPassword = await tinhCongDbContext.UserInfo
                .Where(u => u.UserID == userId && u.UserPassword == password)
                .FirstOrDefaultAsync();

            if (isValidPassword != null)
            {
                try
                {
                    var roles = await (from userInfo in tinhCongDbContext.UserInfo
                                       join userGrp in tinhCongDbContext.UserGrp
                                       on userInfo.UserGrpPrkID equals userGrp.UserGrpPrkID
                                       where userInfo.UserID == userId
                                       select userGrp.UserGrpID)
                                      .FirstOrDefaultAsync();

                    return new AuthResult()
                    {
                        Succeeded = true,
                        //Token = _tokenService.GenerateToken(email, user.FullName!),
                        UserID = userId,
                        RoleName = roles,
                        UserPsnPrkID = user.UserPsnPrkID.ToString()
                    };
                }
                catch (Exception e)
                {
                    // Xử lý ngoại lệ nếu cần thiết
                }
            }

            return new AuthResult()
            {
                Errors = new List<string>() { "Invalid email or password" }
            };
        }

        private bool IsAuthenticated(string username, string password)
        {
            // Implement your authentication logic here
            // Compare the provided username and password with your user data
            // Return true if authenticated, false otherwise
            // This is just a placeholder, and you should replace it with your actual logic
            return username == "user" && password == "password";
        }

        public async Task<AuthResult> RegisterAsync(string email, string password, string fullName)
        {
            var user = new ApplicationUser() { UserName = email, Email = email, FullName = fullName };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                return new AuthResult()
                {
                    Succeeded = true,
                    Token = _tokenService.GenerateToken(email, fullName),
                    UserID = user.UserID
                };
            }

            return new AuthResult()
            {
                Errors = result.Errors.Select(x => x.Description)
            };
        }

        public async Task<AuthResult> ChangePasswordAsync(string email, string oldPassword, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(email)
;
            if (user == null)
                return new AuthResult("Invalid password");

            // Validate password format
            var passwordValidator = new PasswordValidator<ApplicationUser>();
            var result = await passwordValidator.ValidateAsync(_userManager, user, newPassword);
            if (!result.Succeeded)
            {
                return new AuthResult()
                {
                    Errors = result.Errors.Select(e => e.Description).ToList()
                };
            }

            // Validate password and change it
            var identityResult = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
            if (identityResult.Succeeded)
            {
                return new AuthResult()
                {
                    Succeeded = true,
                    Token = _tokenService.GenerateToken(email, user.FullName!),
                    UserID = user.UserID
                };
            }

            return new AuthResult("Invalid password");
        }

    }
}