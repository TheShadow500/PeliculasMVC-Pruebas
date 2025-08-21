using Microsoft.EntityFrameworkCore;

namespace Peliculas.Core.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Pelicula> Peliculas {  get; set; }
    }
}
