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

        public async Task<EmployeeResponse> GetAllEmployees()
        {
            List<Employee> employees = await _employeeRepository.GetAllEmployees();
            foreach (Employee emp in employees)
            {
                EmployeeResponse employeeResponseDTO = new EmployeeResponse();
                employeeResponseDTO.Id = emp.Id;
                employeeResponseDTO.FirstName = emp.FirstName;
                employeeResponseDTO.LastName = emp.LastName;
                employeeResponseDTO.Email = emp.Email;
                employeeResponseDTO.Salary = emp.Salary;
                
            }

            // The method signature expects to return List<Employee>, but you are building List<EmployeeResponse>.
            // You may want to return employeeResponse or change the method signature.
            return employeeResponses;
        }
        public async Task<List<EmployeeResponse>> GetEmployeeById(long id)
        {
            List<Employee> employees = await _employeeRepository.GetAllEmployees();
            List<EmployeeResponse> employeeResponsesDTO = new ();
            foreach(Employee emp in employees)
            {
                EmployeeResponse employeeResponseDTO = new EmployeeResponse();
                employeeResponseDTO.Id = emp.Id;
                employeeResponseDTO.FirstName = emp.FirstName;
                employeeResponseDTO.LastName = emp.LastName;
                employeeResponseDTO.Email = emp.Email;
                employeeResponseDTO.Salary = emp.Salary;

                employeeResponsesDTO.Add(employeeResponseDTO);
            }
            return  employeeResponsesDTO;
        }
    }
}
