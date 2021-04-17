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
        private IEnumerable<TransType> recordSessionList;
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


        protected override async Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);


            transTypeList = (await TransTypeRepo.GetTransTypes()).ToList();

            recordSessionList = transTypeList.Where(x => x.Trans_Type == "RST Used" || x.Trans_Type == "Onsite Used");

            employeeList = (await EmployeeRepo.GetEmployees()).ToList();
            //EmployeeId = _audit.EmployeeId.ToString();




        }

        protected override void OnInitialized()
        {

            base.OnInitialized();

            // initiallise the _audit object
            _audit.Date = DateTime.Now;
            _audit.RecordDate = DateTime.Now;

            // TransTypeId 1 - 4 (not 0 - 3)!!!
            _audit.TransTypeId = 2;
            _audit.CustomerId = CustomerId;
            _audit.Qty = 1;
            _audit.EmployeeId = 1;
            //_audit.ApiUserId = ;



            _editContext = new EditContext(_audit);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();
            
        }



        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();
        }

        private async Task Create()
        {
            _audit.Qty *= -1;
            _audit.Date = DateTime.Now;
            await AuditRepo.CreateAudit(_audit);
            
            ToastService.ShowSuccess($"Action successful." +
                $"Audit \"{_audit.TransTypeId}\" successfully added.");
            
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
