using EmployeeAdmin.DTOs;
using EmployeeAdmin.Models;

namespace EmployeeAdmin.Service
{
    public interface IEmployeeService
    {
         Task<List<EmployeeResponse>> GetAllEmployees();
    }
}
