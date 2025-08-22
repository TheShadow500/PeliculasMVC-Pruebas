using Peliculas.Core;
using Microsoft.EntityFrameworkCore;
using Peliculas.Core.Data;

var builder = WebApplication.CreateBuilder(args);

var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Data\peliculas.db");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={Path.GetFullPath(dbPath)}"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Peliculas}/{action=Index}/{id?}");

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

if (!db.Peliculas.Any())
{
    db.Peliculas.AddRange(
        new Pelicula { Titulo = "Inception", Director = "Christopher Nolan", Anio = 2010, Puntuacion = 8.7 },
        new Pelicula { Titulo = "Interstellar", Director = "Christopher Nolan", Anio = 2014, Puntuacion = 8.6 },
        new Pelicula { Titulo = "The Matrix", Director = "Wachowski Sisters", Anio = 1999, Puntuacion = 8.7 }
    );
    db.SaveChanges();
}

app.Run();
