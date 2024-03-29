﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Net.Http.Headers;
using RSTLog.Features;

namespace RSTLog.AuthProviders
{
    public class AuthStateProvider : AuthenticationStateProvider
    {

        private readonly HttpClient _httpClient;
        //local storgage used to store the token
        private readonly ILocalStorageService _localStorageService;
        private readonly AuthenticationState _anonymous;

        public AuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            //inject services into constructor
            _httpClient = httpClient;
            _localStorageService = localStorage;
            _anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //call the token endpoint
            var token = await _localStorageService.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(token))
                return _anonymous;
            //Add token to the header
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType")));
        }

        public void NotifyUserAuthentication(string token)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(
                JwtParser.ParseClaimsFromJwt(token), "jwtAuthType"));

            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));

            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(_anonymous);

            NotifyAuthenticationStateChanged(authState);
        }
    }
}
