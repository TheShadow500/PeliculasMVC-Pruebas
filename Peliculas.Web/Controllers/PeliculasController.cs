using Microsoft.AspNetCore.Mvc;
using Peliculas.Core.Data;

namespace Peliculas.Web.Controllers
{
    public class PeliculasController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public IActionResult Index()
        {
            var peliculas = _context.Peliculas.ToList();

            return View(peliculas);
        }
    }
}