using System;
using System.Collections.Generic;

namespace EmployeeAdmin.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public decimal? Salary { get; set; }

    public long? DepartmentId { get; set; }

    public string Password { get; set; } = null!;

    public virtual Department? Department { get; set; }
}
