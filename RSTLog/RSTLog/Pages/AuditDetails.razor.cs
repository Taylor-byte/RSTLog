using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class AuditDetails
    {
 
        public Audit Audit { get; set; } = new Audit();
        public Customer Customer { get; set; } = new Customer();

        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        [Parameter]
        public int AuditId { get; set; }

        [Parameter]
        public int CustomerId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Audit = await AuditRepo.GetAudit(AuditId);
        }



    }
}
