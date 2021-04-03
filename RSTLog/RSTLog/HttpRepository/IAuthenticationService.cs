using RSTLog.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IAuthenticationService
    {

        Task<ResponseDTO> RegisterUser(UserForRegistrationDTO userForRegistrationDto);
        Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthenticationDTO);
        Task Logout();

    }
}
