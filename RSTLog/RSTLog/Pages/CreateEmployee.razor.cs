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
    public partial class CreateEmployee
    {

        private Employee _employee = new Employee();
        private EditContext _editContext;
        private bool formInvalid = true;

        public List<Employee> EmployeeList { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeHttpRepository EmployeeRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        protected override void OnInitialized()
        {
            _editContext = new EditContext(_employee);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();
        }

        protected async override Task OnInitializedAsync()
        {
            Interceptor.RegisterEvent();
            await GetEmployees();

        }

        private async Task GetEmployees()
        {
            //list employees in the table
            EmployeeList = await EmployeeRepo.GetEmployees();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();
        }

        private async Task Create()
        {
            await EmployeeRepo.CreateEmployee(_employee);

            //Toaster notifications
            ToastService.ShowSuccess($"Action successful." +
                $"Employee \"{_employee.Name}\" successfully added.");
            _employee = new Employee();
            _editContext.OnValidationStateChanged += ValidationChanged;
            _editContext.NotifyValidationStateChanged();
        }

        private void ValidationChanged(object sender, ValidationStateChangedEventArgs e)
        {
            //form validations when elements change
            formInvalid = true;
            _editContext.OnFieldChanged -= HandleFieldChanged;
            _editContext = new EditContext(_employee);
            _editContext.OnFieldChanged += HandleFieldChanged;
            _editContext.OnValidationStateChanged -= ValidationChanged;
        }

        public void Dispose()
        {
            Interceptor.DisposeEvent();
            _editContext.OnFieldChanged -= HandleFieldChanged;
            _editContext.OnValidationStateChanged -= ValidationChanged;
        }


    }
}
