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

        public Audit _audit = new Audit();
        //private TransType _transType = new TransType();
        private EditContext _editContext;
        private bool formInvalid = true;
        public string TransTypeId { get; set; }
        //private DateTime _dateTimeNow;

        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        //[Parameter]
        public List<TransType> TransTypesList { get; set; } = new List<TransType>();

        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        [Inject]
        public IToastService ToastService { get; set; }

        protected async Task OnInitialzisedAsync()
        {

            //await GetTransTypes();
            TransTypesList = (await TransTypeRepo.GetTransTypes()).ToList();
            TransTypeId = _audit.TransTypeId.ToString();
            //TransTypesList = await TransTypeRepo.GetTransTypes();


        }

        protected override void OnInitialized()
        {

            _audit.RecordDate = DateTime.Now;
            _editContext = new EditContext(_audit);
            _editContext.OnFieldChanged += HandleFieldChanged;
            Interceptor.RegisterEvent();


        }

        

        //private async Task GetTransTypes()
        //{
        //    TransTypesList = await TransTypeRepo.GetTransTypes();

        //    foreach (var transType in TransTypesList)
        //    {
        //        Console.WriteLine(transType.Trans_Type);
        //    }
        //}

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
