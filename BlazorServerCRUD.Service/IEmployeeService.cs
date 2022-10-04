using BlazorServerCRUD.Data.Entities;
using BlazorServerCRUD.Data.Repository;
using BlazorServerCRUD.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCRUD.Service
{
    //Custom entity interface inherits from generic repository interface
    //If you need any specific action for an entity such as id type we can put it here.
    public interface IEmployeeService : IGenericRepository<Employee>
    {
        Employee GetEmployeeById(int employeeId);
        Task<Employee> GetEmployeeByIdAsync(int employeeId);
        Employee AddEmployee(Employee employee);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<AddEmployeeViewModel> AddEmployeeViewModelAsync(AddEmployeeViewModel employee);
        bool RemoveEmployee(Employee employee);
        Task<bool> RemoveEmployeeAsync(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        IQueryable<Employee> GetAllEmployees();
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<List<EmployeeViewModel>> GetAllEmployeeViewModel();
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
