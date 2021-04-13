using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RSTLog.Features;

namespace RSTLog.HttpRepository
{
    public interface ITransTypeHttpRepository
    {
        Task<List<TransType>> GetTransTypes();
        //Task<IEnumerable<TransType>> GetTransTypes();
        Task CreateTransType(TransType transType);

        Task<TransType> GetTransType(int Id);

    }
}
