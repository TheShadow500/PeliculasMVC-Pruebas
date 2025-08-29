using System.ComponentModel.DataAnnotations;

namespace Peliculas.Core
{
    public class Pelicula
    {

        public int Id { get; set; }                             // Clave primaria

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(255, ErrorMessage = "El título no puede tener mas de 255 caracteres")]
        public string Titulo { get; set; } = string.Empty;      // Ej: "Inception"

        [Required(ErrorMessage = "El director es obligatorio")]
        [StringLength(100, ErrorMessage = "El director no puede tener mas de 100 caracteres")]
        public string Director { get; set; } = string.Empty;    // Ej: "Christopher Nolan"

        [Range(1900, 2025, ErrorMessage = "La puntuación debe estar entre 1900 y 2025")]
        public int Anio { get; set; }                           // Ej: 2010

        [Range(0, 10, ErrorMessage = "La puntuación debe estar entre 0 y 10")]
        public double Puntuacion { get; set; }                  // Ej: 8.5
    }
}
