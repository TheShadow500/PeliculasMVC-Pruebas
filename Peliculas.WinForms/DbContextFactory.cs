using Microsoft.EntityFrameworkCore;
using Peliculas.Core.Data;

namespace Peliculas.WinForms
{
    public static class DbContextFactory
    {
        public static AppDbContext Create()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Data\peliculas.db");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite($"Data Source={Path.GetFullPath(dbPath)}")
                .Options;

            return new AppDbContext(options);
        }
    }
}
