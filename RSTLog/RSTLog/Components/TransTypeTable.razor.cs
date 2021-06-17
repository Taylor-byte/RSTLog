﻿using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using RSTLog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class TransTypeTable
    {

        [Parameter]
        public List<TransType> TransTypes { get; set; }

        [Parameter]
        public EventCallback<int> OnDelete { get; set; }
        //conformation modal 
        private Confirmation _confirmation;

        private int _employeeIdToDelete;
        //confirmation for deletion of EMployee
        private void CallConfirmationModal(int Id)
        {
            _employeeIdToDelete = Id;
            _confirmation.Hide();

        }

        private async Task DeleteEmployee()
        {
            _confirmation.Hide();
            await OnDelete.InvokeAsync(_employeeIdToDelete);
        }

    }
}