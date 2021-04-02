using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class Audits : ComponentBase
    {

        public List<Audit> AuditList { get; set; } = new List<Audit>();

        [Inject]
        public IAuditHttpRepository AuditRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            
            AuditList = await AuditRepo.GetAudits();

            foreach (var audit in AuditList)
            {
                Console.WriteLine(audit.Comments);
            }

        }
    }
}
