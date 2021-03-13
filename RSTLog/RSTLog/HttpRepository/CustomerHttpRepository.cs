using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class CustomerHttpRepository : ICustomerHttpRepository
    {
        private readonly HttpClient _client; 

        public CustomerHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var customers = await _client.GetFromJsonAsync<List<Customer>>("customer");

            return customers;
        }
    }
}
