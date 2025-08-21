using Peliculas.Core;

namespace Peliculas.WinForms
{
    public partial class Form1 : Form
    {
        private List<Pelicula> peliculas = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Agregar(object sender, EventArgs e)
        {
            try
            {
                // Crea la película

                var pelicula = new Pelicula
                {
                    Id = peliculas.Count + 1,
                    Titulo = tb_Titulo.Text,
                    Director = tb_Director.Text,
                    Anio = int.Parse(tb_Anio.Text),
                    Puntuacion = double.Parse(tb_Puntuacion.Text)
                };

                // Agrega a la lista
                peliculas.Add(pelicula);

                // Refresca el DataGridView
                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = peliculas;

                // Limpiar inputs
                tb_Titulo.Clear();
                tb_Director.Clear();
                tb_Anio.Clear();
                tb_Puntuacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la película: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
