using System.ComponentModel.DataAnnotations;

namespace NewMVC.Models;

public class Employee : Person
{
    [Required]
    public string EmployeeId { get; set; } = string.Empty;

    [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
    public int Age { get; set; }
}
