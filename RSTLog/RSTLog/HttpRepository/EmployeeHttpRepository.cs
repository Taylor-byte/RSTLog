using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class EmployeeHttpRepository : IEmployeeHttpRepository
    {

        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;

        public EmployeeHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }


        public async Task CreateEmployee(Employee employee)
            => await _client.PostAsJsonAsync("Employee", employee);

        public Task DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _client.GetFromJsonAsync<List<Employee>>("Employee");

            return employees;
        }
    }
}
