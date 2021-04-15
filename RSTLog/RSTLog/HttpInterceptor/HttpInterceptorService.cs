﻿using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace RSTLog.HttpInterceptor
{
    public class HttpInterceptorService
    {

        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navManager;
        private readonly IToastService _toastService;
        private readonly RefreshTokenService _refreshTokenService;

        public HttpInterceptorService(HttpClientInterceptor interceptor, 
            NavigationManager navManager, IToastService toastService,
            RefreshTokenService refreshTokenService)
        {
            _interceptor = interceptor;
            _navManager = navManager;
            _toastService = toastService;
            _refreshTokenService = refreshTokenService;
        }

        public void RegisterEvent() => _interceptor.AfterSend += HandleResponse;
        public void RegisterBeforeSendEvent() =>
            _interceptor.BeforeSendAsync += InterceptBeforeSendAsync;


        public void DisposeEvent()
        {
            _interceptor.AfterSend -= HandleResponse;
            _interceptor.BeforeSendAsync -= InterceptBeforeSendAsync;
        }

        private async Task InterceptBeforeSendAsync(object sender, HttpClientInterceptorEventArgs e)
        {
            var absolutePath = e.Request.RequestUri.AbsolutePath;
            //does the path contain the token or account info. . If not then refresh token.
            if (!absolutePath.Contains("token") && !absolutePath.Contains("account"))
            {
                var token = await _refreshTokenService.TryRefreshToken();
                if (!string.IsNullOrEmpty(token))
                {
                    e.Request.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
                }
            }
        }

        private void HandleResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            if (e.Response == null)
            {
                _navManager.NavigateTo("/error");
                throw new HttpResponseException("Server Not Available");
            }

            var message = "";

            if (!e.Response.IsSuccessStatusCode)
            {

                switch (e.Response.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        _navManager.NavigateTo("/404");
                        message = "Resource not found.";
                            break;
                    case HttpStatusCode.BadRequest:
                        message = "Invalid request. Please try again.";
                        _toastService.ShowError(message);
                        break;
                    case HttpStatusCode.Unauthorized:
                        _navManager.NavigateTo("/unauthorized");
                        message = "Unauthorized access";
                        break;
                    default:
                        _navManager.NavigateTo("/404");
                        message = "Something went wrong :( unlucky. Please contact the administrator.";
                        break;
                }

                throw new HttpResponseException(message);

            }





        }
    }
}
