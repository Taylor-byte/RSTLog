using Microsoft.AspNetCore.Components;
using RSTLog.DTO;
using RSTLog.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class ForgotPassword
    {

        private ForgotPasswordDTO _forgotPasswordDTO = new ForgotPasswordDTO();
        private bool _showSuccess;
        private bool _showError;

        [Inject]
        public IAuthenticationService AuthService { get; set; }

        private async Task Submit()
        {
            _showSuccess = _showError = false;
            var result = await AuthService.ForgotPassword(_forgotPasswordDTO);
            if (result == HttpStatusCode.OK)
                _showSuccess = true;
            else
                _showError = true;
        }


    }
}
