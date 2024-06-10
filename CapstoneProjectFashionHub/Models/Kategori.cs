using System.ComponentModel.DataAnnotations;

namespace CapstoneProjectFashionHub.Models
{
    public class Kategori
    {

        [Key]
        public int ID_Kategori { get; set; }
        [Required]
        public string? Nama_Kategori { get; set; }
    }
}
