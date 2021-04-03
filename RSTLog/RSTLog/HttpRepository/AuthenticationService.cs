using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using RSTLog.AuthProviders;
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
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;
        public AuthenticationService(HttpClient client, 
            AuthenticationStateProvider authStateProvider,
            ILocalStorageService localStorage)
        {
            _client = client;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        public async Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthenticationDto)
        {
            var response = await _client.PostAsJsonAsync("Account/Login", userForAuthenticationDto);

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<AuthResponseDTO>(content, _options);

            if (!response.IsSuccessStatusCode)
                return result;

            await _localStorage.SetItemAsync("authToken", result.Token);

            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(
                userForAuthenticationDto.Email);
            

            return new AuthResponseDTO { IsAuthSuccessful = true };
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");

            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();

            _client.DefaultRequestHeaders.Authorization = null;

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
