using System.ComponentModel.DataAnnotations;

namespace CapstoneProjectFashionHub.Models
{
    public class Layanan
    {
        [Key]
        public int ID_Layanan { get; set; }
        [Required]
        public string? Nama_Layanan { get; set; }
        [Required]
        public string? Deskripsi { get; set; }
        [Required]
        public double? Biaya { get; set ; }
    }
}
