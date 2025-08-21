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
            lb_Titulo = new Label();
            tb_Titulo = new TextBox();
            tb_Director = new TextBox();
            lb_Director = new Label();
            tb_Anio = new TextBox();
            lb_Anio = new Label();
            tb_Puntuacion = new TextBox();
            lb_Puntuacion = new Label();
            bt_Agregar = new Button();
            dgvPeliculas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Titulo.ForeColor = Color.White;
            lb_Titulo.Location = new Point(14, 12);
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
            tb_Titulo.Location = new Point(142, 12);
            tb_Titulo.Name = "tb_Titulo";
            tb_Titulo.Size = new Size(227, 27);
            tb_Titulo.TabIndex = 1;
            // 
            // tb_Director
            // 
            tb_Director.BackColor = SystemColors.ScrollBar;
            tb_Director.BorderStyle = BorderStyle.FixedSingle;
            tb_Director.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Director.Location = new Point(142, 45);
            tb_Director.Name = "tb_Director";
            tb_Director.Size = new Size(227, 27);
            tb_Director.TabIndex = 3;
            // 
            // lb_Director
            // 
            lb_Director.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Director.ForeColor = Color.White;
            lb_Director.Location = new Point(14, 45);
            lb_Director.Name = "lb_Director";
            lb_Director.Size = new Size(122, 27);
            lb_Director.TabIndex = 2;
            lb_Director.Text = "Director";
            lb_Director.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_Anio
            // 
            tb_Anio.BackColor = SystemColors.ScrollBar;
            tb_Anio.BorderStyle = BorderStyle.FixedSingle;
            tb_Anio.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Anio.Location = new Point(142, 78);
            tb_Anio.Name = "tb_Anio";
            tb_Anio.Size = new Size(227, 27);
            tb_Anio.TabIndex = 5;
            // 
            // lb_Anio
            // 
            lb_Anio.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Anio.ForeColor = Color.White;
            lb_Anio.Location = new Point(14, 78);
            lb_Anio.Name = "lb_Anio";
            lb_Anio.Size = new Size(122, 27);
            lb_Anio.TabIndex = 4;
            lb_Anio.Text = "Año";
            lb_Anio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_Puntuacion
            // 
            tb_Puntuacion.BackColor = SystemColors.ScrollBar;
            tb_Puntuacion.BorderStyle = BorderStyle.FixedSingle;
            tb_Puntuacion.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Puntuacion.Location = new Point(142, 111);
            tb_Puntuacion.Name = "tb_Puntuacion";
            tb_Puntuacion.Size = new Size(227, 27);
            tb_Puntuacion.TabIndex = 7;
            // 
            // lb_Puntuacion
            // 
            lb_Puntuacion.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Puntuacion.ForeColor = Color.White;
            lb_Puntuacion.Location = new Point(14, 111);
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
            bt_Agregar.Location = new Point(268, 154);
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
            dgvPeliculas.Location = new Point(385, 12);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(403, 426);
            dgvPeliculas.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPeliculas);
            Controls.Add(bt_Agregar);
            Controls.Add(tb_Puntuacion);
            Controls.Add(lb_Puntuacion);
            Controls.Add(tb_Anio);
            Controls.Add(lb_Anio);
            Controls.Add(tb_Director);
            Controls.Add(lb_Director);
            Controls.Add(tb_Titulo);
            Controls.Add(lb_Titulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private TextBox tb_Titulo;
        private TextBox tb_Director;
        private Label lb_Director;
        private TextBox tb_Anio;
        private Label lb_Anio;
        private TextBox tb_Puntuacion;
        private Label lb_Puntuacion;
        private Button bt_Agregar;
        private DataGridView dgvPeliculas;
    }
}
