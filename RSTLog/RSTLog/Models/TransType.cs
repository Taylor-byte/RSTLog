using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Models
{
    public class TransType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Trans_Type { get; set; }

    }
}
