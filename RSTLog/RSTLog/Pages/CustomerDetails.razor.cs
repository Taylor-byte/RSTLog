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

        

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);

            int balance = Customer.Audit.Where(a => a.TransTypeId == 3 || a.TransTypeId == 4).Sum(a => a.Qty);

        }

        
    }
}
