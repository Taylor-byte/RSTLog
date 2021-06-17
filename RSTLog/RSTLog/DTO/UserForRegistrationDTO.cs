using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.DTO
{
    public class UserForRegistrationDTO
    {
        [Required(ErrorMessage="Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Compare(nameof(Password), 
            ErrorMessage = "The passwords entered do not match")]
        public string ConfirmPassword { get; set; }


    }
}
