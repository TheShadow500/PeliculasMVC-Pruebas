namespace Peliculas.WinForms
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lb_Titulo = new Label();
            tb_Title = new TextBox();
            tb_Director = new TextBox();
            lb_Director = new Label();
            lb_Anio = new Label();
            lb_Puntuacion = new Label();
            bt_Agregar = new Button();
            dgvPeliculas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Director = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            peliculaBindingSource = new BindingSource(components);
            bt_Editar = new Button();
            bt_Eliminar = new Button();
            cb_Year = new ComboBox();
            cb_Rating = new ComboBox();
            panel_Opciones = new Panel();
            bt_Actualizar = new Button();
            appDbContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).BeginInit();
            panel_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
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
            tb_Title.BackColor = SystemColors.ScrollBar;
            tb_Title.BorderStyle = BorderStyle.FixedSingle;
            tb_Title.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Title.Location = new Point(140, 285);
            tb_Title.Name = "tb_Titulo";
            tb_Title.Size = new Size(285, 27);
            tb_Title.TabIndex = 1;
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
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.AllowUserToResizeColumns = false;
            dgvPeliculas.AllowUserToResizeRows = false;
            dgvPeliculas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Director, Anio, Puntuacion });
            dgvPeliculas.DataSource = peliculaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeliculas.Location = new Point(12, 12);
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPeliculas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPeliculas.RowHeadersVisible = false;
            dgvPeliculas.ScrollBars = ScrollBars.Vertical;
            dgvPeliculas.Size = new Size(701, 233);
            dgvPeliculas.TabIndex = 9;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 50;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Título";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Resizable = DataGridViewTriState.False;
            Titulo.Width = 250;
            // 
            // Director
            // 
            Director.DataPropertyName = "Director";
            Director.HeaderText = "Director";
            Director.Name = "Director";
            Director.ReadOnly = true;
            Director.Resizable = DataGridViewTriState.False;
            Director.Width = 200;
            // 
            // Anio
            // 
            Anio.DataPropertyName = "Anio";
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            Anio.ReadOnly = true;
            Anio.Resizable = DataGridViewTriState.False;
            Anio.Width = 75;
            // 
            // Puntuacion
            // 
            Puntuacion.DataPropertyName = "Puntuacion";
            Puntuacion.HeaderText = "Puntuación";
            Puntuacion.Name = "Puntuacion";
            Puntuacion.ReadOnly = true;
            Puntuacion.Resizable = DataGridViewTriState.False;
            // 
            // peliculaBindingSource
            // 
            peliculaBindingSource.DataSource = typeof(Core.Pelicula);
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
            cb_Year.BackColor = SystemColors.ScrollBar;
            cb_Year.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Year.FlatStyle = FlatStyle.Flat;
            cb_Year.Font = new Font("Roboto Condensed", 12F);
            cb_Year.FormattingEnabled = true;
            cb_Year.Location = new Point(140, 351);
            cb_Year.Name = "cb_Anio";
            cb_Year.Size = new Size(90, 27);
            cb_Year.TabIndex = 12;
            // 
            // cb_Puntuacion
            // 
            cb_Rating.BackColor = SystemColors.ScrollBar;
            cb_Rating.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Rating.FlatStyle = FlatStyle.Flat;
            cb_Rating.Font = new Font("Roboto Condensed", 12F);
            cb_Rating.FormattingEnabled = true;
            cb_Rating.Location = new Point(140, 385);
            cb_Rating.Name = "cb_Puntuacion";
            cb_Rating.Size = new Size(90, 27);
            cb_Rating.TabIndex = 13;
            // 
            // panel_Opciones
            // 
            panel_Opciones.BackColor = SystemColors.WindowFrame;
            panel_Opciones.BorderStyle = BorderStyle.FixedSingle;
            panel_Opciones.Controls.Add(bt_Actualizar);
            panel_Opciones.Controls.Add(bt_Agregar);
            panel_Opciones.Controls.Add(bt_Editar);
            panel_Opciones.Controls.Add(bt_Eliminar);
            panel_Opciones.Location = new Point(486, 260);
            panel_Opciones.Name = "panel_Opciones";
            panel_Opciones.Size = new Size(200, 188);
            panel_Opciones.TabIndex = 14;
            // 
            // bt_Actualizar
            // 
            bt_Actualizar.BackColor = SystemColors.ButtonFace;
            bt_Actualizar.FlatStyle = FlatStyle.Flat;
            bt_Actualizar.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Actualizar.Location = new Point(50, 133);
            bt_Actualizar.Name = "bt_Actualizar";
            bt_Actualizar.Size = new Size(101, 32);
            bt_Actualizar.TabIndex = 12;
            bt_Actualizar.Text = "ACTUALIZAR";
            bt_Actualizar.UseVisualStyleBackColor = false;
            bt_Actualizar.Click += Actualizar;
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Core.Data.AppDbContext);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(725, 451);
            Controls.Add(panel_Opciones);
            Controls.Add(cb_Rating);
            Controls.Add(cb_Year);
            Controls.Add(dgvPeliculas);
            Controls.Add(lb_Puntuacion);
            Controls.Add(lb_Anio);
            Controls.Add(tb_Director);
            Controls.Add(lb_Director);
            Controls.Add(tb_Title);
            Controls.Add(lb_Titulo);
            Name = "Form1";
            Text = "Peliculas - Pruebas ASP.NET Core, Razor y Entity Framework";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).EndInit();
            panel_Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private TextBox tb_Title;
        private TextBox tb_Director;
        private Label lb_Director;
        private Label lb_Anio;
        private Label lb_Puntuacion;
        private Button bt_Agregar;
        private DataGridView dgvPeliculas;
        private Button bt_Editar;
        private Button bt_Eliminar;
        private ComboBox cb_Year;
        private ComboBox cb_Rating;
        private Panel panel_Opciones;
        private Button bt_Actualizar;
        private BindingSource peliculaBindingSource;
        private BindingSource appDbContextBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Director;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Puntuacion;
    }
}
