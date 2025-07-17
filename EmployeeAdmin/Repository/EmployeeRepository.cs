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
    }
}
