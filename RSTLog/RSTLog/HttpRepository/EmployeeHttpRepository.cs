using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class EmployeeHttpRepository : IEmployeeHttpRepository
    {
        //Http repository for handling requests to the API
        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;

        public EmployeeHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }

        //HTTP methods for calling the API POST, PUT GET etc
        public async Task CreateEmployee(Employee employee)
            => await _client.PostAsJsonAsync("Employee", employee);
            
        //Path.combine constructs the app url.
        public async Task DeleteEmployee(int id)
            => await _client.DeleteAsync(Path.Combine("Employee", id.ToString()));

        

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _client.GetFromJsonAsync<Employee>($"Employee/{id}");

            return employee;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _client.GetFromJsonAsync<List<Employee>>("Employee");

            return employees;
        }

        public Task UpdateEmployee(Employee employee)
             => _client.PutAsJsonAsync(Path.Combine("Employee",
             employee.Id.ToString()), employee);
    }
}
