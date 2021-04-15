using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.DTO
{
    public class ResetPasswordResponseDTO
    {
        public bool IsResetPasswordSuccessful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
