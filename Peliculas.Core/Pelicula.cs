namespace Peliculas.Core
{
    public class Pelicula
    {
        public int Id { get; set; }             // Clave primaria
        public string Titulo { get; set; }      // Ej: "Inception"
        public string Director {  get; set; }   // Ej: "Christopher Nolan"
        public int Anio { get; set; }           // Ej: 2010
        public double Puntuacion { get; set; }  // Ej: 8.5
    }
}
