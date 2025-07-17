using EmployeeAdmin.Models;

namespace EmployeeAdmin.Repository
{

    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
    }
}
