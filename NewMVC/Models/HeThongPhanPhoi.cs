using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

namespace NewMVC.Models;

public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string TenHTPP { get; set; } = string.Empty;
    public ICollection<DaiLy>? DaiLys { get; set; }

}
