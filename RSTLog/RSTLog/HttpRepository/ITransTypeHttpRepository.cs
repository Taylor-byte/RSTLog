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
        //Task<TransType> GetTransType(int id);

        Task CreateTransType(TransType transType);
    }
}
