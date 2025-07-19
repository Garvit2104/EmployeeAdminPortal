using EmployeeAdmin.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdmin.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeePortalContext _context;

        public EmployeeRepository(EmployeePortalContext context)
        {
            _context = context;
        }

        // Implement the correct interface method
        public async Task<List<Employee>> GetAllEmployees()
        {
            var result = await _context.Employees.ToListAsync();
            return result;
        }
        public async Task<Employee> GetEmployeeById(long id)
        {
            var result = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            return result;
        }

        public async Task<bool> DeleteEmployee(long id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return false;
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        public Employee AddEmployee(Employee employee)
        {
            Employee result = _context.Employees.Add(employee).Entity;
            _context.SaveChanges();
            return result;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            //var existingEmployee = _context.Employees.Find(id);
            //if (existingEmployee == null) {
            //    return null;
            //}
            //existingEmployee.FirstName = employee.FirstName;
            //existingEmployee.LastName = employee.LastName;  
            //existingEmployee.Email = employee.Email;
            //existingEmployee.Salary = employee.Salary;
            //existingEmployee.Password = employee.Password;

            var result = _context.Employees.Update(employee).Entity;
            _context.SaveChanges();
            return result;
        }
    }
}
