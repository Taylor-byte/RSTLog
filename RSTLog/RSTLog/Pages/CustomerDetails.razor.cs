using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class CustomerDetails
    {
        //instanciate required models
        public Customer Customer { get; set; } = new Customer();

        public Audit Audit { get; set; } = new Audit();

        public List<Audit> AuditList { get; set; } = new List<Audit>();
        public List<TransType> TransTypeList { get; set; } = new List<TransType>();

        public TransType TransType { get; set; } = new TransType();

        public MetaData MetaData { get; set; } = new MetaData();

        private RequestParams _requestParams = new RequestParams();

        private bool IsDisabled { get; set; }


        // Http Repositories
        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }
        //id for routing
        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);

            //calcualtion for the customers remote service ticket balances. 
            //Calcualted on the fly based number on transaction types in the table relating to that customer
            Customer.RSTBalance = Customer.Audit.Where(a => a.TransTypeId == 1 || a.TransTypeId == 2).Sum(a => a.Qty);
            Customer.OnsiteBalance = Customer.Audit.Where(a => a.TransTypeId == 3 || a.TransTypeId == 4).Sum(a => a.Qty);

            

            await GetAudits();
        }

        protected override void OnInitialized()
        {
            if (Customer.RSTBalance > 0)
            {
                IsDisabled = false;
            }
            else
            {
                IsDisabled = true;
            }
        }


        private async Task SelectedPage(int page)
        {

            _requestParams.PageNumber = page;



            await GetAudits();
        }


        private async Task GetAudits()
        {
            var pagingResponse = await AuditRepo.GetAudits(_requestParams, Customer.Id);
            AuditList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }


        public async Task SetPageSize(int pageSize)
        {
            _requestParams.PageSize = pageSize;
            _requestParams.PageNumber = 1;

            await GetAudits();
        }


    }
}
