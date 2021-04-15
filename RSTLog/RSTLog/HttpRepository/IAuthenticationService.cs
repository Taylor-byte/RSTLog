using RSTLog.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IAuthenticationService
    {

        Task<ResponseDTO> RegisterUser(UserForRegistrationDTO userForRegistrationDto);
        Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthenticationDTO);
        Task Logout();
        Task<string> RefreshToken();

        Task<HttpStatusCode> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO);

        Task<ResetPasswordResponseDTO> ResetPassword(ResetPasswordDTO resetPasswordDTO);

    }
}
