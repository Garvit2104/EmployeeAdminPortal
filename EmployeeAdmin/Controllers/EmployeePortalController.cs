using EmployeeAdmin.DTOs;
using EmployeeAdmin.Repository;
using EmployeeAdmin.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePortalController : ControllerBase
    {
        
        private readonly IEmployeeService _employeeService;
        public EmployeePortalController(IEmployeeService service)
        {
            _employeeService = service;    
        }
        [HttpGet("GetAllEmployees")]

        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await _employeeService.GetAllEmployees();
            return Ok(result);
        }
        [HttpGet("GetEmployeeById/{id}")]

        public async Task<IActionResult> GetEmployeeById(long id)
        {
            var result = await  _employeeService.GetEmployeeById(id);
            if (result == null)
            {
                return await Task.FromResult<IActionResult>(NotFound());
            }
            return await Task.FromResult<IActionResult>(Ok(result));

        }
        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee(long id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result)
            {
                return Ok(new { message = "Employee deleted successfully." });
            }
            else
            {
                return NotFound(new { message = "Employee not found." });
            }
        }
        [HttpPost("AddEmployee")]

        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var result = _employeeService.AddEmployee(addEmployeeDto);
            return Ok(result);
        }
        [HttpPut("UpdateEmployee")]

        public IActionResult UpdateEmployee(long id, AddEmployeeDto addEmployeeDto)
        {
            var result = _employeeService.UpdateEmployee(id, addEmployeeDto);
            return Ok(result);
        }

    }
}
