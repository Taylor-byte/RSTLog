﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.DTO
{
    public class ResetPasswordDTO
    {
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
		[Compare(nameof(Password),
			ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
		public string Email { get; set; }
		public string Token { get; set; }
	}
}
