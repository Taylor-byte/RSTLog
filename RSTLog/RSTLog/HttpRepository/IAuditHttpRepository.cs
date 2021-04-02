using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IAuditHttpRepository
    {
        Task<List<Audit>> GetAudits();
       // Task<Audit> GetAudit(int id);
    }
}
