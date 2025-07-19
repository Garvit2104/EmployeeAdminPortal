namespace EmployeeAdmin.DTOs
{
    public class AddEmployeeDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; } = null!;

        public decimal? Salary { get; set; }

        public string Password { get; set; } = null!;
    }
}
