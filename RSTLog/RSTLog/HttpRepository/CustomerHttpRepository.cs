using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using RSTLog.Features;
using RSTLog.Models;
using RSTLog.Paging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class CustomerHttpRepository : ICustomerHttpRepository
    {
        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true,  };
        public CustomerHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }

        public async Task CreateCustomer(Customer customer)
            => await _client.PostAsJsonAsync("Customer", customer);



        public async Task<Customer> GetCustomer(int id)
        {
            var customer = await _client.GetFromJsonAsync<Customer>($"Customer/{id}");

            return customer;
        }

        public async Task<PagingResponse<Customer>> GetCustomers(RequestParams requestParams)
        {

            var queryStringParam = new Dictionary<string, string>
            {
                //["totalCount"] = requestParams.TotalCount.ToString(),
                ["pageNumber"] = requestParams.PageNumber.ToString(),
                //["currentPage"] = requestParams.CurrentPage.ToString(),
                ["pageSize"] = requestParams.PageSize.ToString(),
                ["searchTerm"] = requestParams.SearchTerm == null ? "" : requestParams.SearchTerm,
                ["orderBy"] = requestParams.OrderBy == null ? "" : requestParams.OrderBy


            };

            //$"customer?pageNumber={requestParams.PageNumber}"
            var response = await _client.GetAsync(QueryHelpers.AddQueryString("Customer", queryStringParam));

            var content = await response.Content.ReadAsStringAsync();

            var pagingResponse = new PagingResponse<Customer>
            {
                Items = JsonSerializer.Deserialize<List<Customer>>(content, _options),
                MetaData = JsonSerializer.Deserialize<MetaData>(
                    response.Headers.GetValues("X-Pagination").First(), _options)
            };

            return pagingResponse;
        }

        public Task UpdateCustomer(Customer customer)
            => _client.PostAsJsonAsync(Path.Combine("customers",
                customer.Id.ToString()), customer);

        public async Task DeleteCustomer(int Id)
            => await _client.DeleteAsync(Path.Combine("customers", Id.ToString()));

    }
}
