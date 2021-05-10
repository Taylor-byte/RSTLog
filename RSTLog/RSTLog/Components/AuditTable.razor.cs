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
        public List<Audit> Audits { get; set; }

        //[Parameter]
        //public TransType TransType { get; set; }

        [Parameter]
        public int CustomerId { get; set; }


    }

}

