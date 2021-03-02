using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        public int? HoursPurchased { get; set; }

        public int? HoursRemaining { get; set; }

        public DateTime Invoiced { get; set; }

        public string Notes { get; set; }

        public int? OnsitePurchased { get; set; }

        public bool Paid { get; set; }

        
    }
}
