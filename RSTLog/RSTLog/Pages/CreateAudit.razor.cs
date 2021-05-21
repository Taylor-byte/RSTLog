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
    public partial class CreateAudit
    {
        //This is the add credit code. add credit button on the customer details uses this logic.

        private Audit _audit = new Audit();
        private IList<TransType> transTypesList;
        private IEnumerable<TransType> addCreditList;
        private EditContext _editContext;
        private bool formInvalid = true;
        //private string TransTypeId { get; set; }

        public Customer Customer { get; set; } = new Customer();
        //Http Repositores
        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //await base.OnInitializedAsync();

            Customer = await CustomerRepo.GetCustomer(CustomerId);
            transTypesList = (await TransTypeRepo.GetTransTypes()).ToList();
            //Transaction type list only displays the relevent trans types to adding a credit
            addCreditList = transTypesList.Where(x => x.Trans_Type == "RST Purchased" || x.Trans_Type == "Onsite Purchased");
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            // initiallise the _audit object
            _audit.Date = DateTime.Now;
            _audit.RecordDate = DateTime.Now;

            // TransTypeId 1 - 4 (not 0 - 3)!!!
            _audit.TransTypeId = 1;
            _audit.CustomerId = CustomerId;
            _audit.Qty = 1;
            //_audit.EmployeeId = ;
            //_audit.ApiUserId = ;


            _editContext = new EditContext(_audit);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();
        }

        //Field changes for validation
        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            formInvalid = !_editContext.Validate();
            StateHasChanged();
        }

        private async Task Create()
        {
            // Refresh date so it is set to the actual save time
            _audit.Date = DateTime.Now;

            await AuditRepo.CreateAudit(_audit);
            //_audit.Date = DateTime.Now();
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
