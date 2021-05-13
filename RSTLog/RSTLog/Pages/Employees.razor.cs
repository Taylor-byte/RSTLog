using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class Employees
    {
        private Employee _employee = new Employee();

        public List<Employee> EmployeeList { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeHttpRepository EmployeeRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            
            await GetEmployees();

        }

        private async Task GetEmployees()
        {
            //list employees in the table
            EmployeeList = await EmployeeRepo.GetEmployees();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
