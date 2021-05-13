using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using RSTLog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class CustomerTable
    {
        [Parameter]
        public List<Customer> Customers { get; set; }

        [Parameter]
        public EventCallback<int> OnDelete { get; set; }

        private Confirmation _confirmation;

        private int _customerIdToDelete;

        //confirmation for deletion of customer
        private void CallConfirmationModal(int Id)
        {
            _customerIdToDelete = Id;
            _confirmation.Hide();
            
        }

        private async Task DeleteCustomer()
        {
            _confirmation.Hide();
            await OnDelete.InvokeAsync(_customerIdToDelete);
        }
    }
}
