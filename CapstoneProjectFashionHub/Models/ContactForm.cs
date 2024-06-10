using System.ComponentModel.DataAnnotations;
namespace CapstoneProjectFashionHub.Models
{
    public class ContactForm 
    {
        [Key]
        public int IdKontak { get; set; }
        [Required]
        public string? Nama { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Topik { get; set;}
        [Required]
        public string? Pesan { get; set; }
    }
}
