using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class Customers
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>();

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            CustomerList = await CustomerRepo.GetCustomers();

            foreach(var customer in CustomerList)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
