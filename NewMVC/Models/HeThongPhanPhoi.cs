using System.ComponentModel.DataAnnotations;

namespace NewMVC.Models;

public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string TenHTPP { get; set; } = string.Empty;
}
