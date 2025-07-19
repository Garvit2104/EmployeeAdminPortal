using EmployeeAdmin.Repository;
using EmployeeAdmin.Models;
using EmployeeAdmin.DTOs;
using System.Collections;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;
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
            List<EmployeeResponse> employeeResponses = new List<EmployeeResponse>();
            foreach (Employee emp in employees)
            {
                EmployeeResponse employeeResponseDTO = new EmployeeResponse();
                employeeResponseDTO.Id = emp.Id;
                employeeResponseDTO.FirstName = emp.FirstName;
                employeeResponseDTO.LastName = emp.LastName;
                employeeResponseDTO.Email = emp.Email;
                employeeResponseDTO.Salary = emp.Salary;
                employeeResponses.Add(employeeResponseDTO);
            }
            return employeeResponses;
        }
        public async Task<EmployeeResponse> GetEmployeeById(long id)
        {
            Employee emp = await _employeeRepository.GetEmployeeById(id);
            
                EmployeeResponse employeeResponseDTO = new EmployeeResponse();
                employeeResponseDTO.Id = emp.Id;
                employeeResponseDTO.FirstName = emp.FirstName;
                employeeResponseDTO.LastName = emp.LastName;
                employeeResponseDTO.Email = emp.Email;
                employeeResponseDTO.Salary = emp.Salary;

            return employeeResponseDTO;
        }

        public async Task<bool> DeleteEmployee(long id)
        {
           return await _employeeRepository.DeleteEmployee(id);
            
        
        }
        public async Task<EmployeeResponse> AddEmployee(AddEmployeeDto employeeDto)
        {
            Employee employeeEntity = new()
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                Salary = employeeDto.Salary,
                Password = employeeDto.Password
            };
            Employee employee = _employeeRepository.AddEmployee(employeeEntity);
            EmployeeResponse employeeResponse = new()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Password = employee.Password,
                Salary = employee.Salary
            };

            return employeeResponse;
    
        }
        public EmployeeResponse UpdateEmployee(long id, AddEmployeeDto addEmployeeDto)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id).Result;
            if (employee == null)
            {
                return null;
            }
            
            employee.FirstName = addEmployeeDto.FirstName;  
            employee.LastName = addEmployeeDto.LastName;
            employee.Email = addEmployeeDto.Email;
            employee.Salary = addEmployeeDto.Salary;
            employee.Password = addEmployeeDto.Password;

            employee = _employeeRepository.UpdateEmployee(employee);

            EmployeeResponse employeeResponse = new()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Salary = employee.Salary,
                Password = employee.Password
            };
            return employeeResponse;
        }


    }
    }

