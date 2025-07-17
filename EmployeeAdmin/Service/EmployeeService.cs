using EmployeeAdmin.Repository;
using EmployeeAdmin.Models;
using EmployeeAdmin.DTOs;
using System.Collections;
namespace EmployeeAdmin.Service
{
   
public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public async Task<List<EmployeeResponse>> GetAllEmployees()
        {
            List<Employee> employees = await _employeeRepository.GetAllEmployees();
            List<EmployeeResponse> employeeResponses = new();

            foreach (Employee emp in employees)
            {
                EmployeeResponse employeeResponse = new EmployeeResponse();
                employeeResponse.Id = emp.Id;
                employeeResponse.FirstName = emp.FirstName;
                employeeResponse.LastName = emp.LastName;
                employeeResponse.Email = emp.Email;
                employeeResponse.Salary = emp.Salary;
                employeeResponses.Add(employeeResponse);
            }

            // The method signature expects to return List<Employee>, but you are building List<EmployeeResponse>.
            // You may want to return employeeResponse or change the method signature.
            return employeeResponses;
        }
    }
}
