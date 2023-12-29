using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Recruit.Client.Services;
using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using Recruit.Server.Models;
using Recruit.Server.Models.ModelView;
using Recruit.Shared.ViewModels;
using System.Text.Json.Serialization;

namespace Recruit.Client.Services
{

    public class TinhCongService : ITinhCongService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorageService;

        public TinhCongService(HttpClient httpClient,
            AuthenticationStateProvider authenticationStateProvider,
            ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorageService = localStorageService;
        }

        public async Task<int> updateTinhNgayCong(ChamCongHeader ngayCong)
        {
            var response = await _httpClient.PostAsJsonAsync($"/NgayCong/Update", ngayCong);
            var authResult = await response.Content.ReadFromJsonAsync<int>();
            return authResult;
        }

        public async Task<List<NgayCong>> layNgayCongToanBoNV(DayToSearch dayToSearch)
        {

                var response = await _httpClient.PostAsJsonAsync($"/Search", dayToSearch);
                var authResult = await response.Content.ReadFromJsonAsync<List<NgayCong>?>();
                return authResult ?? new List<NgayCong>();
        }

        public async Task<List<NgayCong>> getsNhanVien()
        {
            var response = await _httpClient.GetFromJsonAsync<List<NgayCong>>($"/getsNhanVien");
            return response ?? new List<NgayCong>();
        }        
        public async Task<List<ChamCongType>> getsLoaiChamCong()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ChamCongType>>($"/getsLoaiChamCong");
            return response ?? new List<ChamCongType>();
        }

        public async Task<NgayCong> layNhanvienbyEmail(string email)
        {
            var response = await _httpClient.GetFromJsonAsync<NgayCong>($"/layNhanvienbyEmail/{email}");
            return response ?? new NgayCong();
        }

        public async Task<ChamCongHeader?> getNgayCong(string maNV, string ngay, string thang, string nam)
        {
            var response = await _httpClient.GetFromJsonAsync<ChamCongHeader>($"/getNgayCong/{maNV}/{ngay}/{thang}/{nam}");
            return response;
        }

        public async Task<decimal> getMaChamCongHeader(int PsnPrkID, int thangcc, int namcc)
        {
            var response = await _httpClient.GetFromJsonAsync<decimal>($"/getMaChamCongHeader/{PsnPrkID}/{thangcc}/{namcc}");
            return response;
        }

        public async Task DeleteNgayCong(decimal? MngChamCongPrkID, DateTime fromDay, DateTime toDay)
        {
            var response = await _httpClient.PostAsJsonAsync($"/NgayCong/Delete", new { MngChamCongPrkID, fromDay, toDay});
            return;
        }
    }
}
