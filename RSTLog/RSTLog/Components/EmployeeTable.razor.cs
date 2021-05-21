using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using RSTLog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class EmployeeTable
    {

        [Parameter]
        public List<Employee> Employees { get; set; }
        //callback for delete specific Id
        [Parameter]
        public EventCallback<int> OnDelete { get; set; }
        //variable for confirmation modal
        private Confirmation _confirmation;

        private int _employeeIdToDelete;
        //confirmation for deletion of Employee
        private void CallConfirmationModal(int id)
        {
            _employeeIdToDelete = id;
            _confirmation.Show();

        }
        //Delete employee with specific Id
        private async Task DeleteEmployee()
        {
            _confirmation.Hide();
            await OnDelete.InvokeAsync(_employeeIdToDelete);
        }
    }


}

