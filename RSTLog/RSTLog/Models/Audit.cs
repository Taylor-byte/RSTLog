using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Models
{
    public class Audit
    {
        
        public int Id { get; set; }

        public int CustomerId { get; set; }
        
        public int EmployeeId { get; set; }

        public int TransTypeId { get; set; }
        
        public int ApiUserId { get; set; }

        public DateTime Date { get; set; }

        public DateTime RecordDate { get; set; }

        public int Qty { get; set; }

        public string Comments { get; set; }
    }
}
