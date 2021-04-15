using RSTLog.Features;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IAuditHttpRepository
    {
        //Task<List<Audit>> GetAudits();

        Task<PagingResponse<Audit>> GetAudits(RequestParams requestParams);

        Task<Audit> GetAudit(int id);

        Task CreateAudit(Audit audit);

        Task<List<TransType>> GetTransTypes();

        //Task UpdateCustomer(Customer customer);

        //Task DeleteCustomer(int Id);
    }
}
