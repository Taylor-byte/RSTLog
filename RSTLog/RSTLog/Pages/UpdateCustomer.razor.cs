using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RSTLog.HttpInterceptor;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class UpdateCustomer : IDisposable
    {
        private Customer _customer;
        private EditContext _editContext;
        private bool formInvalid = true;

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _customer = await CustomerRepo.GetCustomer(Id);
            _editContext = new EditContext(_customer);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();
        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();
        }

        private async Task Update()
        {
            await CustomerRepo.UpdateCustomer(_customer);

            ToastService.ShowSuccess($"Action successful." +
                $"Customer \"{_customer.Name}\" successfully updated.");
            //_customer = new Customer();

        }

       

        public void Dispose()
        {
            Interceptor.DisposeEvent();
            _editContext.OnFieldChanged -= HandleFieldChanged;
            
        }

    }
}
