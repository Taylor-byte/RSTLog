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
        public Customer Customer { get; set; } = new Customer();

        public Audit Audit { get; set; } = new Audit();

        public List<Audit> AuditList { get; set; } = new List<Audit>();
        public List<TransType> TransTypeList { get; set; } = new List<TransType>();

        public MetaData MetaData { get; set; } = new MetaData();

        private RequestParams _requestParams = new RequestParams();

        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);

            int balance = Customer.Audit.Where(a => a.TransTypeId == 3 || a.TransTypeId == 4).Sum(a => a.Qty);
            Console.WriteLine("Customer Balance: " + balance.ToString());

            await GetAudits();
        }

        private async Task SelectedPage(int page)
        {

            _requestParams.PageNumber = page;



            await GetAudits();
        }


        private async Task GetAudits()
        {
            var pagingResponse = await AuditRepo.GetAudits(_requestParams);
            AuditList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        public async Task SetPageSize(int pageSize)
        {
            _requestParams.PageSize = pageSize;
            _requestParams.PageNumber = 1;

            await GetAudits();
        }

        //private async Task SearchChanged(string searchTerm)
        //{
        //    _requestParams.PageNumber = 1;
        //    _requestParams.SearchTerm = searchTerm;

        //    await GetAudits();
        //}


    }
}
