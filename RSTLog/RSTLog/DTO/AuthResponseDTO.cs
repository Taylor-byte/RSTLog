using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.DTO
{
    public class AuthResponseDTO
    {
        //DTO for taking the authroisation response from the API
        public bool IsAuthSuccessful { get; set; }

        public string ErrorMessage { get; set; }
        public string Token { get; set; }

        public string RefreshToken { get; set; }

    }
}
