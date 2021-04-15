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
    public partial class RecordSession
    {

        private Audit _audit = new Audit();
        private IList<TransType> transTypeList;
        private IList<Employee> employeeList;
        private EditContext _editContext;
        private bool formInvalid = true;

        public Customer Customer { get; set; } = new Customer();

        public string TransTypeId { get; set; }
        public string EmployeeId { get; set; }

        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        [Inject]
        public IEmployeeHttpRepository EmployeeRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected override void OnInitialized()
        {
            _audit.Date = DateTime.Now;
            _editContext = new EditContext(_audit);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();

        }

        protected override async Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);

            transTypeList = (await TransTypeRepo.GetTransTypes()).ToList();
            TransTypeId = _audit.TransTypeId.ToString();

            employeeList = (await EmployeeRepo.GetEmployees()).ToList();
            EmployeeId = _audit.EmployeeId.ToString();




        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();
        }

        private async Task Create()
        {
            await AuditRepo.CreateAudit(_audit);
            //            _audit.Date = DateTime.Now();
            ToastService.ShowSuccess($"Action successful." +
                $"Audit \"{_audit.TransTypeId}\" successfully added.");
            _audit.CustomerId = CustomerId;
            _audit = new Audit();
            _editContext.OnValidationStateChanged += ValidationChanged;
            _editContext.NotifyValidationStateChanged();
        }

        private void ValidationChanged(object sender, ValidationStateChangedEventArgs e)
        {
            formInvalid = true;
            _editContext.OnFieldChanged -= HandleFieldChanged;
            _editContext = new EditContext(_audit);
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
