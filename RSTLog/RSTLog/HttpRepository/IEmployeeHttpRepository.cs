using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public interface IEmployeeHttpRepository
    {
        //Interface for http repository. Corresponding repositories implement this interface
        Task<List<Employee>> GetEmployees();
        Task CreateEmployee(Employee employee);

        Task<Employee> GetEmployee(int id);

        Task UpdateEmployee(Employee employee);

        Task DeleteEmployee(int id);

    }
}
