using APIConEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace APIConEntityFramework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // public DbSet<NombreModelo> "NombreTabla" { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
