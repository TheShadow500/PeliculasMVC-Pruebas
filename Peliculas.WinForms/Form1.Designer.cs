namespace Peliculas.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lb_Titulo = new Label();
            tb_Titulo = new TextBox();
            tb_Director = new TextBox();
            lb_Director = new Label();
            lb_Anio = new Label();
            lb_Puntuacion = new Label();
            bt_Agregar = new Button();
            dgvPeliculas = new DataGridView();
            bt_Editar = new Button();
            bt_Eliminar = new Button();
            cb_Anio = new ComboBox();
            cb_Puntuacion = new ComboBox();
            panel_Opciones = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            panel_Opciones.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Titulo.ForeColor = Color.White;
            lb_Titulo.Location = new Point(12, 285);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(122, 27);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "Título";
            lb_Titulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_Titulo
            // 
            tb_Titulo.BackColor = SystemColors.ScrollBar;
            tb_Titulo.BorderStyle = BorderStyle.FixedSingle;
            tb_Titulo.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Titulo.Location = new Point(140, 285);
            tb_Titulo.Name = "tb_Titulo";
            tb_Titulo.Size = new Size(285, 27);
            tb_Titulo.TabIndex = 1;
            // 
            // tb_Director
            // 
            tb_Director.BackColor = SystemColors.ScrollBar;
            tb_Director.BorderStyle = BorderStyle.FixedSingle;
            tb_Director.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Director.Location = new Point(140, 318);
            tb_Director.Name = "tb_Director";
            tb_Director.Size = new Size(285, 27);
            tb_Director.TabIndex = 3;
            // 
            // lb_Director
            // 
            lb_Director.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Director.ForeColor = Color.White;
            lb_Director.Location = new Point(12, 318);
            lb_Director.Name = "lb_Director";
            lb_Director.Size = new Size(122, 27);
            lb_Director.TabIndex = 2;
            lb_Director.Text = "Director";
            lb_Director.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_Anio
            // 
            lb_Anio.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Anio.ForeColor = Color.White;
            lb_Anio.Location = new Point(12, 351);
            lb_Anio.Name = "lb_Anio";
            lb_Anio.Size = new Size(122, 27);
            lb_Anio.TabIndex = 4;
            lb_Anio.Text = "Año";
            lb_Anio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_Puntuacion
            // 
            lb_Puntuacion.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Puntuacion.ForeColor = Color.White;
            lb_Puntuacion.Location = new Point(12, 384);
            lb_Puntuacion.Name = "lb_Puntuacion";
            lb_Puntuacion.Size = new Size(122, 27);
            lb_Puntuacion.TabIndex = 6;
            lb_Puntuacion.Text = "Puntuación";
            lb_Puntuacion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bt_Agregar
            // 
            bt_Agregar.BackColor = SystemColors.ButtonFace;
            bt_Agregar.FlatStyle = FlatStyle.Flat;
            bt_Agregar.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Agregar.Location = new Point(50, 19);
            bt_Agregar.Name = "bt_Agregar";
            bt_Agregar.Size = new Size(101, 32);
            bt_Agregar.TabIndex = 8;
            bt_Agregar.Text = "AGREGAR";
            bt_Agregar.UseVisualStyleBackColor = false;
            bt_Agregar.Click += Bt_Agregar;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPeliculas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPeliculas.Location = new Point(12, 12);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(701, 233);
            dgvPeliculas.TabIndex = 9;
            // 
            // bt_Editar
            // 
            bt_Editar.BackColor = SystemColors.ButtonFace;
            bt_Editar.FlatStyle = FlatStyle.Flat;
            bt_Editar.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Editar.Location = new Point(50, 57);
            bt_Editar.Name = "bt_Editar";
            bt_Editar.Size = new Size(101, 32);
            bt_Editar.TabIndex = 10;
            bt_Editar.Text = "EDITAR";
            bt_Editar.UseVisualStyleBackColor = false;
            bt_Editar.Click += Bt_Editar;
            // 
            // bt_Eliminar
            // 
            bt_Eliminar.BackColor = SystemColors.ButtonFace;
            bt_Eliminar.FlatStyle = FlatStyle.Flat;
            bt_Eliminar.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Eliminar.Location = new Point(50, 95);
            bt_Eliminar.Name = "bt_Eliminar";
            bt_Eliminar.Size = new Size(101, 32);
            bt_Eliminar.TabIndex = 11;
            bt_Eliminar.Text = "ELIMINAR";
            bt_Eliminar.UseVisualStyleBackColor = false;
            bt_Eliminar.Click += Bt_Eliminar;
            // 
            // cb_Anio
            // 
            cb_Anio.BackColor = SystemColors.ScrollBar;
            cb_Anio.FlatStyle = FlatStyle.Flat;
            cb_Anio.Font = new Font("Roboto Condensed", 12F);
            cb_Anio.FormattingEnabled = true;
            cb_Anio.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cb_Anio.Location = new Point(140, 351);
            cb_Anio.Name = "cb_Anio";
            cb_Anio.Size = new Size(108, 27);
            cb_Anio.TabIndex = 12;
            // 
            // cb_Puntuacion
            // 
            cb_Puntuacion.BackColor = SystemColors.ScrollBar;
            cb_Puntuacion.FlatStyle = FlatStyle.Flat;
            cb_Puntuacion.Font = new Font("Roboto Condensed", 12F);
            cb_Puntuacion.FormattingEnabled = true;
            cb_Puntuacion.Items.AddRange(new object[] { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "5.7", "5.8", "5.9", "6.0", "6.1", "6.2", "6.3", "6.4", "6.5", "6.6", "6.7", "6.8", "6.9", "7.0", "7.1", "7.2", "7.3", "7.4", "7.5", "7.6", "7.7", "7.8", "7.9", "8.0", "8.1", "8.2", "8.3", "8.4", "8.5", "8.6", "8.7", "8.8", "8.9", "9.0", "9.1", "9.2", "9.3", "9.4", "9.5", "9.6", "9.7", "9.8", "9.9", "10.0" });
            cb_Puntuacion.Location = new Point(140, 385);
            cb_Puntuacion.Name = "cb_Puntuacion";
            cb_Puntuacion.Size = new Size(108, 27);
            cb_Puntuacion.TabIndex = 13;
            // 
            // panel_Opciones
            // 
            panel_Opciones.BackColor = SystemColors.WindowFrame;
            panel_Opciones.BorderStyle = BorderStyle.FixedSingle;
            panel_Opciones.Controls.Add(bt_Agregar);
            panel_Opciones.Controls.Add(bt_Editar);
            panel_Opciones.Controls.Add(bt_Eliminar);
            panel_Opciones.Location = new Point(486, 275);
            panel_Opciones.Name = "panel_Opciones";
            panel_Opciones.Size = new Size(200, 147);
            panel_Opciones.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(725, 451);
            Controls.Add(panel_Opciones);
            Controls.Add(cb_Puntuacion);
            Controls.Add(cb_Anio);
            Controls.Add(dgvPeliculas);
            Controls.Add(lb_Puntuacion);
            Controls.Add(lb_Anio);
            Controls.Add(tb_Director);
            Controls.Add(lb_Director);
            Controls.Add(tb_Titulo);
            Controls.Add(lb_Titulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            panel_Opciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private TextBox tb_Titulo;
        private TextBox tb_Director;
        private Label lb_Director;
        private Label lb_Anio;
        private Label lb_Puntuacion;
        private Button bt_Agregar;
        private DataGridView dgvPeliculas;
        private Button bt_Editar;
        private Button bt_Eliminar;
        private ComboBox cb_Anio;
        private ComboBox cb_Puntuacion;
        private Panel panel_Opciones;
    }
}
