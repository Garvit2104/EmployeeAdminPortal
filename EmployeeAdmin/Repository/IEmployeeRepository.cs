using EmployeeAdmin.Models;

namespace EmployeeAdmin.Repository
{

    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task <Employee> GetEmployeeById(long id);
    }
}
