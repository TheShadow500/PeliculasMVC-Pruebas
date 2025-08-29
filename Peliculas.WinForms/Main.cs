using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Peliculas.Core;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Peliculas.WinForms
{
    public partial class Main : Form
    {
        readonly private List<Pelicula> peliculas = [];
        public Main()
        {
            InitializeComponent();
            Load += SecuenciaInicio;

            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.CellClick += DgvPeliculas_Seleccion;

            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                cb_Year.Items.Add(i.ToString());
            }

            for (double i = 10; i >= 0; i -= 0.1)
            {
                cb_Rating.Items.Add(i.ToString("0.0").Replace(',', '.'));
            }
        }

        private void SecuenciaInicio(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            using var db = DbContextFactory.Create();
            dgvPeliculas.DataSource = db.Peliculas
                .OrderBy(p => p.Titulo)
                .ToList();
        }

        private void Actualizar(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void LimpiarInputs()
        {
            tb_Title.Clear();
            tb_Director.Clear();
            cb_Year.SelectedIndex = -1;
            cb_Rating.SelectedIndex = -1;
        }

        private void Bt_Agregar(object sender, EventArgs e)
        {
            using var db = DbContextFactory.Create();

            // Extract the data
            string title = tb_Title.Text ?? string.Empty;                           // Title
            string director = tb_Director.Text ?? string.Empty;                     // Director
            string year = cb_Year.SelectedItem?.ToString() ?? string.Empty;         // Year
            string rating = cb_Rating.SelectedItem?.ToString() ?? string.Empty;     // Rating

            try
            {
                // Crea la película
                var movie = new Pelicula
                {
                    Titulo = title,
                    Director = director,
                    Anio = int.TryParse(year, out var parsedYear) ? parsedYear : -1,
                    Puntuacion = double.TryParse(rating.Replace('.', ','), out var parsedRating) ? parsedRating : -1,
                };

                var context = new ValidationContext(movie);
                var results = new List<ValidationResult>();
                if(!Validator.TryValidateObject(movie, context, results, true))
                {
                    string errores = string.Join("\n", results.Select(r => r.ErrorMessage));
                    MessageBox.Show(errores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parsea el año y el rating
                movie.Anio = int.Parse(year);
                movie.Puntuacion = double.Parse(rating.Replace('.', ','));

                // Agrega a la lista
                db.Peliculas.Add(movie);
                db.SaveChanges();

                // Refresca el DataGridView
                CargarPeliculas();

                // Limpia los campos
                LimpiarInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la película: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Editar(object sender, EventArgs e)
        {
            if (peliculaSeleccionadaId == null)
            {
                MessageBox.Show("Seleccione una película para editar");
                return;
            }

            using var db = DbContextFactory.Create();
            var pelicula = db.Peliculas.Find(peliculaSeleccionadaId);

            if (pelicula != null)
            {
                pelicula.Titulo = tb_Title.Text;
                pelicula.Director = tb_Director.Text;
                pelicula.Anio = int.Parse(cb_Year.SelectedItem.ToString());
                pelicula.Puntuacion = double.Parse(cb_Rating.SelectedItem.ToString().Replace('.', ','));

                db.SaveChanges();
                CargarPeliculas();
                LimpiarInputs();
            }
        }

        private void Bt_Eliminar(object sender, EventArgs e)
        {
            if (peliculaSeleccionadaId == null)
            {
                MessageBox.Show("Seleccione una película para eliminar");
                return;
            }

            var respuesta = MessageBox.Show("¿Estás seguro de que quieres eliminar esta película?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                using var db = DbContextFactory.Create();
                var pelicula = db.Peliculas.Find(peliculaSeleccionadaId);

                if (pelicula != null)
                {
                    db.Peliculas.Remove(pelicula);
                    db.SaveChanges();
                    CargarPeliculas();
                    LimpiarInputs();
                }
            }
        }

        private int? peliculaSeleccionadaId = null;

        private void DgvPeliculas_Seleccion(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPeliculas.Rows[e.RowIndex];
                peliculaSeleccionadaId = (int)fila.Cells["Id"].Value;

                tb_Title.Text = fila.Cells["Titulo"].Value.ToString();
                tb_Director.Text = fila.Cells["Director"].Value.ToString();
                cb_Year.SelectedItem = fila.Cells["Anio"].Value.ToString();
                cb_Rating.SelectedItem = fila.Cells["Puntuacion"].Value.ToString().Replace(',', '.');
            }
        }
    }
}
