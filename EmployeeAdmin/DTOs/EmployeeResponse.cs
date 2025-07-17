namespace EmployeeAdmin.DTOs
{
    public class EmployeeResponse
    {
        public long Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; } = null!;

        public decimal? Salary { get; set; }
    }
}
