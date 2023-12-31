﻿using System.ComponentModel.DataAnnotations;

namespace Recruit.Shared.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]
        public string? UserId { get; set; }
        public string? Email { get; set; }

        [Required]
        //[DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
