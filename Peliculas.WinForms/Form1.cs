using Peliculas.Core;
using System.Security.Cryptography;

namespace Peliculas.WinForms
{
    public partial class Form1 : Form
    {
        readonly private List<Pelicula> peliculas = [];
        public Form1()
        {
            InitializeComponent();
            Load += SecuenciaInicio;

            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.CellClick += DgvPeliculas_Seleccion;
        }

        private void SecuenciaInicio (object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            using var db = DbContextFactory.Create();
            dgvPeliculas.DataSource = db.Peliculas.ToList();
        }

        private void LimpiarInputs()
        {
            tb_Titulo.Clear();
            tb_Director.Clear();
            cb_Anio.SelectedIndex = -1;
            cb_Puntuacion.SelectedIndex = -1;
        }

        private void Bt_Agregar(object sender, EventArgs e)
        {
            using var db = DbContextFactory.Create();

            try
            {
                // Crea la película
                var pelicula = new Pelicula
                {
                    Titulo = tb_Titulo.Text,
                    Director = tb_Director.Text,
                    Anio = int.Parse(cb_Anio.SelectedItem.ToString()),
                    Puntuacion = double.Parse(cb_Puntuacion.SelectedItem.ToString().Replace('.', ','))
                };

                // Agrega a la lista
                db.Peliculas.Add(pelicula);
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
                pelicula.Titulo = tb_Titulo.Text;
                pelicula.Director = tb_Director.Text;
                pelicula.Anio = int.Parse(cb_Anio.SelectedItem.ToString());
                pelicula.Puntuacion = double.Parse(cb_Puntuacion.SelectedItem.ToString().Replace('.', ','));

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

                tb_Titulo.Text = fila.Cells["Titulo"].Value.ToString();
                tb_Director.Text = fila.Cells["Director"].Value.ToString();
                cb_Anio.SelectedItem = fila.Cells["Anio"].Value.ToString();
                cb_Puntuacion.SelectedItem = fila.Cells["Puntuacion"].Value.ToString().Replace(',', '.');
            }
        }

    }
}
