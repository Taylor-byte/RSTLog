using RSTLog.Features;
using RSTLog.Models;
using RSTLog.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface ICustomerHttpRepository
    {
        Task<PagingResponse<Customer>> GetCustomers(RequestParams requestParams);
        Task<Customer> GetCustomer(int id);

        Task CreateCustomer(Customer customer);

        Task UpdateCustomer(Customer customer);

        Task DeleteCustomer(int Id);
    }
}