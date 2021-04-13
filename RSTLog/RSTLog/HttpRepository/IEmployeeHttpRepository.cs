using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IEmployeeHttpRepository
    {

        Task <List<Employee>> GetEmployees();
        Task CreateEmployee(Employee employee);

        Task DeleteEmployee(int Id);

    }
}
