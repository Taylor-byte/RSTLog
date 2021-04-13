using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RSTLog.Features;
using RSTLog.Paging;
using RSTLog.HttpInterceptor;

namespace RSTLog.Pages
{
    public partial class Customers : IDisposable
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>();
        public MetaData MetaData { get; set; } = new MetaData();

        private RequestParams _requestParams = new RequestParams();

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }
        [Inject]
        public HttpInterceptorService Interceptor { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Interceptor.RegisterEvent();
            Interceptor.RegisterBeforeSendEvent();
            await GetCustomers();

        }

        //private async Task SelectedPage(int page, int pageSize)
        private async Task SelectedPage(int page)
        { 

            _requestParams.PageNumber = page;
            


            await GetCustomers();
        }

        private async Task GetCustomers()
        {
            var pagingResponse = await CustomerRepo.GetCustomers(_requestParams);
            CustomerList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        public async Task SetPageSize(int pageSize)
        {
            _requestParams.PageSize = pageSize;
            _requestParams.PageNumber = 1;

            await GetCustomers();
        }

        private async Task SearchChanged(string searchTerm)
        {
            _requestParams.PageNumber = 1;
            _requestParams.SearchTerm = searchTerm;

            await GetCustomers();
        }

        private async Task SortChanged(string orderBy)
        {
            _requestParams.OrderBy = orderBy;

            await GetCustomers();
        }

        private async Task DeleteCustomer(int id)
        {
            await CustomerRepo.DeleteCustomer(id);

            //Paging needs to be recalculated after a delete. 
            if (_requestParams.PageNumber > 1 && CustomerList.Count == 1)
                _requestParams.PageNumber --;

            await GetCustomers();
        }

        public void Dispose() => Interceptor.DisposeEvent();


    }
}
