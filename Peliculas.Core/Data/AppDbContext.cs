using Microsoft.EntityFrameworkCore;

namespace Peliculas.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Pelicula> Peliculas {  get; set; }
    }
}
