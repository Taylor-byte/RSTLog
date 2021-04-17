using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }

        public int? HoursPurchased { get; set; }

        public int? HoursRemaining { get; set; }

        public DateTime? Invoiced { get; set; }

        public string Notes { get; set; }

        public int? OnsitePurchased { get; set; }

        public bool Paid { get; set; }
        
        public string InvoicedDate { get; set; }

        public int OnsiteBalance { get; set; }

        public int RSTBalance { get; set; }

        public List<Audit> Audit { get; set; }

    }
}
