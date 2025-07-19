using EmployeeAdmin.DTOs;
using EmployeeAdmin.Models;

namespace EmployeeAdmin.Service
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>> GetAllEmployees();

        Task<EmployeeResponse> GetEmployeeById(long id);

        Task<bool> DeleteEmployee(long id);

        Task<EmployeeResponse> AddEmployee(AddEmployeeDto employeeDto);

        EmployeeResponse UpdateEmployee(long id, AddEmployeeDto employeeDto);

    }
}
