using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface ICustomerHttpRepository
    {
        Task<List<Customer>> GetCustomers();
    }
}