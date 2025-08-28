using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewMVC.Models;

public class DaiLy
{
    [Key]
    public string MaDaiLy { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string TenDaiLy { get; set; } = string.Empty;

    [StringLength(200)]
    public string? DiaChi { get; set; }

    [StringLength(100)]
    public string? NguoiDaiDien { get; set; }

    [Phone]
    public string? DienThoai { get; set; }

    // Khóa ngoại
    [Required]
    public string MaHTPP { get; set; } = string.Empty;

    [ForeignKey("MaHTPP")]
    public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
}
