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
    public partial class UpdateEmployee
    {
        private Employee _employee;
        private EditContext _editContext;
        private bool formInvalid = true;

        [Inject]
        public IEmployeeHttpRepository EmployeeRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _employee = await EmployeeRepo.GetEmployee(Id);
            _editContext = new EditContext(_employee);
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
            await EmployeeRepo.UpdateEmployee(_employee);

            ToastService.ShowSuccess($"Action successful." +
                $"Employee \"{_employee.Name}\" successfully updated.");
            _employee = new Employee();

        }



        public void Dispose()
        {
            Interceptor.DisposeEvent();
            _editContext.OnFieldChanged -= HandleFieldChanged;

        }

    }

}

