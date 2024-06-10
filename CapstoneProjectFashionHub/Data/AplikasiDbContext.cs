using CapstoneProjectFashionHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProjectFashionHub.Data
{
    public class AplikasiDbContext : DbContext
    {
        public AplikasiDbContext(DbContextOptions<AplikasiDbContext> options) : base(options)
        {}

        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Layanan> Layanan { get; set; }
    }
}
