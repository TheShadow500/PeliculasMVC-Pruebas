using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Peliculas.Core;
using Peliculas.Core.Data;
using Peliculas.Web.Models;
using System.Diagnostics;
using X.PagedList.Extensions;

namespace Peliculas.Web.Controllers
{
    public class HomeController(AppDbContext context, ILogger<HomeController> logger) : Controller
    {
        private readonly AppDbContext _context = context;
        private readonly ILogger<HomeController> _logger = logger;

        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            var peliculas = _context.Peliculas
                .OrderBy(p => p.Titulo)
                .ToPagedList(pageNumber, pageSize);
            return View(peliculas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pelicula);
                await _context.SaveChangesAsync();
                TempData["Message"] = $"Se ha añadido la película '{pelicula.Titulo}' ";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Pelicula pelicula)
        {
            if (id != pelicula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(pelicula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            _context.Peliculas.Remove(pelicula);
            await _context.SaveChangesAsync();

            TempData["Message"] = $"Película '{pelicula.Titulo}' eliminada correctamente.";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
