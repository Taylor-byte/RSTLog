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

        [Inject]
        public ICustomerHttpRepository CustomerRepo { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Customer = await CustomerRepo.GetCustomer(CustomerId);
        }


    }
}
