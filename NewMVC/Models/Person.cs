using System.ComponentModel.DataAnnotations;

namespace NewMVC.Models;

public class Person
{
    [Key]
    public string PersonId { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    [StringLength(200)]
    public string? Address { get; set; }
}
