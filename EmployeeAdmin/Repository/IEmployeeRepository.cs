using EmployeeAdmin.Models;

namespace EmployeeAdmin.Repository
{

    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task <Employee> GetEmployeeById(long id);

        Task<bool> DeleteEmployee(long id);

        Employee AddEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);
    }
}
