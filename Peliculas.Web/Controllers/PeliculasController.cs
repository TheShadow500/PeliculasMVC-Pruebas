using Microsoft.AspNetCore.Mvc;
using Peliculas.Core;

namespace Peliculas.Web.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Index()
        {
            var peliculas = new List<Pelicula>
            {
                new() { Id = 1, Titulo = "Inception", Director = "Christopher Nolan", Anio = 2010, Puntuacion = 8.7 },
                new() { Id = 2, Titulo = "Interstellar", Director = "Christopher Nolan", Anio = 2014, Puntuacion = 8.6 },
                new() { Id = 3, Titulo = "The Matrix", Director = "Wachowski Sisters", Anio = 1999, Puntuacion = 8.7 }
            };

            return View(peliculas);
        }
    }
}