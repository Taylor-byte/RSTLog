using Microsoft.AspNetCore.Components;
using RSTLog.Models;
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
    }
}
