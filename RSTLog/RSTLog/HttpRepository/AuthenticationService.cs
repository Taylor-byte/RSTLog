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
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.IO;

namespace RSTLog.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true, };
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _navManager;
        public AuthenticationService(HttpClient client, 
            AuthenticationStateProvider authStateProvider,
            ILocalStorageService localStorage,
            NavigationManager navManager)
        {
            _client = client;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
            _navManager = navManager;
        }

        public async Task<HttpStatusCode> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO )
        {
            forgotPasswordDTO.ClientURI =
                Path.Combine(_navManager.BaseUri, "resetPassword");

            var result = await _client.PostAsJsonAsync("account/forgotpassword",
                forgotPasswordDTO);

            return result.StatusCode;
        }

        public async Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthenticationDto)
        {
            var response = await _client.PostAsJsonAsync("Account/Login", userForAuthenticationDto);

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<AuthResponseDTO>(content, _options);

            if (!response.IsSuccessStatusCode)
                return result;

            await _localStorage.SetItemAsync("authToken", result.Token);
            await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);

            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(
                result.Token);

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "bearer", result.Token);

            return new AuthResponseDTO { IsAuthSuccessful = true };
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            await _localStorage.RemoveItemAsync("refreshToken");

            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();

            _client.DefaultRequestHeaders.Authorization = null;

        }

        public async Task<string> RefreshToken()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");
            var refreshToken = await _localStorage.GetItemAsync<string>("refreshToken");

            var response = await _client.PostAsJsonAsync("token/refresh",
                new RefreshTokenDTO
                {
                    Token = token,
                    RefreshToken = refreshToken
                });

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<AuthResponseDTO>(content, _options);

            await _localStorage.SetItemAsync("authToken", result.Token);
            await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("bearer", result.Token);

            return result.Token;
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

        public async Task<ResetPasswordResponseDTO> ResetPassword(ResetPasswordDTO resetPasswordDTO)
        {
            var resetResult = await _client.PostAsJsonAsync("account/resetpassword",
                resetPasswordDTO);

            var resetContent = await resetResult.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<ResetPasswordResponseDTO>(resetContent,
                _options);

            return result;
        }
    }
}
