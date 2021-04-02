using RSTLog.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true, };
        public AuthenticationService(HttpClient client)
        {
            _client = client;
        }
        public async Task<ResponseDTO> RegisterUser(UserForRegistrationDTO userForRegistrationDto)
        {
            var response = await _client.PostAsJsonAsync("Account/register", userForRegistrationDto);

            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<ResponseDTO>(content, _options);

                return result;

            }

            return new ResponseDTO { IsSuccessfulRegistration = true };
        }
    }
}
