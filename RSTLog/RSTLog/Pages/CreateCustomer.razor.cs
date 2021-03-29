using Microsoft.AspNetCore.Components;
using RSTLog.HttpInterceptor;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class CreateCustomer
    {
        private Customer _customer = new Customer();

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        protected override void OnInitialized()
        {
            Interceptor.RegisterEvent();
        }

        private async Task Create()
        {
            await CustomerRepo.CreateCustomer(_customer);
        }

        public void Dispose() => Interceptor.DisposeEvent();
    }
}
