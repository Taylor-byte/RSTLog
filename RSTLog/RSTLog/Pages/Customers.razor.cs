using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RSTLog.Features;
using RSTLog.Paging;


namespace RSTLog.Pages
{
    public partial class Customers
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>();
        public MetaData MetaData { get; set; } = new MetaData();

        private RequestParams _requestParams = new RequestParams();

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetCustomers();

        }

        //private async Task SelectedPage(int page, int pageSize)
        private async Task SelectedPage(int page)
        { 

            _requestParams.PageNumber = page;
            //_requestParams.PageSize = pageSize;


            await GetCustomers();
        }

        private async Task GetCustomers()
        {
            var pagingResponse = await CustomerRepo.GetCustomers(_requestParams);
            CustomerList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
