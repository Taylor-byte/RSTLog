using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RSTLog.AuthProviders;
using RSTLog.HttpInterceptor;
using RSTLog.HttpRepository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace RSTLog
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped((sp, cl) => new HttpClient
            //{
            //    cl.BaseAddress = new Uri("https://localhost:44323/api/")
            //    cl.EnableIntercept(sp)

            //});

            builder.Services.AddHttpClient("WebAPI", (sp, cl) =>
            {
                cl.BaseAddress = new Uri("https://localhost:44323/api/");
                cl.EnableIntercept(sp);

            });

            builder.Services.AddBlazoredToast();

            builder.Services.AddScoped(
                sp => sp.GetService<IHttpClientFactory>().CreateClient("WebAPI"));

            builder.Services.AddHttpClientInterceptor();

            builder.Services.AddScoped<ICustomerHttpRepository, CustomerHttpRepository>();

            builder.Services.AddScoped<ITransTypeHttpRepository, TransTypeHttpRepository>();

            builder.Services.AddScoped<IAuditHttpRepository, AuditHttpRepository>();

            builder.Services.AddScoped<HttpInterceptorService>();

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();

            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

            await builder.Build().RunAsync();
        }
    }
}
