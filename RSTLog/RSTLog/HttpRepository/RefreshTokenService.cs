﻿using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class RefreshTokenService
    {

        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly IAuthenticationService _authService;

        public RefreshTokenService(AuthenticationStateProvider authStateProvider,
            IAuthenticationService authService)
        {
            //inject authentication services into constructor
            _authStateProvider = authStateProvider;
            _authService = authService;
        }

        public async Task<string> TryRefreshToken()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            var expClaim = user.FindFirst(c => c.Type.Equals("exp")).Value;
            //Token expiry time variable
            var expTime = DateTimeOffset.FromUnixTimeSeconds(
                Convert.ToInt64(expClaim));

            //work out difference between token expiry
            var diff = expTime - DateTime.UtcNow;
            if (diff.TotalMinutes <= 2)
                return await _authService.RefreshToken();

            return string.Empty;

        }

    }
}
