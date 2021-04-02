using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using RSTLog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class AuditTable
    {

        [Parameter]
        public List<Audit> Audit { get; set; }
        //[Parameter]
       // public Customer Customer { get; set; }

        [Parameter]
        public TransType TransType { get; set; }

        //[Parameter]
        //public EventCallback<int> OnDelete { get; set; }

       // private Confirmation _confirmation;

        //private int _auditIdToDelete;

        //private void CallConfirmationModal(int Id)
        //{
        //    _auditIdToDelete = Id;
        //    _confirmation.Hide();

        //}

        //private async Task DeleteAudit()
        //{
        //    _confirmation.Hide();
        //    await OnDelete.InvokeAsync(_auditIdToDelete);
        //}
    }

}

