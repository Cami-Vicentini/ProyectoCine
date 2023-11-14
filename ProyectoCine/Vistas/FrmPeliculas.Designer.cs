namespace ProyectoCine.Vistas
{
    partial class FrmPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeliculas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDirector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-4, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboDirector);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.brnCancelar);
            this.panel4.Controls.Add(this.btnAceptar);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Controls.Add(this.lblDia);
            this.panel4.Controls.Add(this.lblSala);
            this.panel4.Controls.Add(this.dtpHora);
            this.panel4.Controls.Add(this.dtpDia);
            this.panel4.Controls.Add(this.cboSala);
            this.panel4.Controls.Add(this.txtTitulo);
            this.panel4.Controls.Add(this.cboGenero);
            this.panel4.Controls.Add(this.nudDuracion);
            this.panel4.Controls.Add(this.cboClasificacion);
            this.panel4.Controls.Add(this.cboIdioma);
            this.panel4.Controls.Add(this.lblClasificacion);
            this.panel4.Controls.Add(this.lblDuracion);
            this.panel4.Controls.Add(this.lblIdioma);
            this.panel4.Controls.Add(this.lblGenero);
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Location = new System.Drawing.Point(27, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 474);
            this.panel4.TabIndex = 79;
            // 
            // brnCancelar
            // 
            this.brnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.brnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brnCancelar.Location = new System.Drawing.Point(495, 382);
            this.brnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(169, 55);
            this.brnCancelar.TabIndex = 34;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(279, 382);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(169, 55);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(493, 315);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(91, 33);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "Hora:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDia.Location = new System.Drawing.Point(493, 244);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(71, 33);
            this.lblDia.TabIndex = 31;
            this.lblDia.Text = "Dia:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSala.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSala.Location = new System.Drawing.Point(13, 313);
            this.lblSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(86, 33);
            this.lblSala.TabIndex = 30;
            this.lblSala.Text = "Sala:";
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(592, 310);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(180, 40);
            this.dtpHora.TabIndex = 29;
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(572, 241);
            this.dtpDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(180, 40);
            this.dtpDia.TabIndex = 28;
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(112, 316);
            this.cboSala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(180, 28);
            this.cboSala.TabIndex = 27;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(145, 63);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(183, 26);
            this.txtTitulo.TabIndex = 17;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(148, 149);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(180, 28);
            this.cboGenero.TabIndex = 19;
            // 
            // nudDuracion
            // 
            this.nudDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudDuracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDuracion.Location = new System.Drawing.Point(650, 171);
            this.nudDuracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(80, 40);
            this.nudDuracion.TabIndex = 23;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(700, 64);
            this.cboClasificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(218, 28);
            this.cboClasificacion.TabIndex = 25;
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(148, 235);
            this.cboIdioma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(180, 28);
            this.cboIdioma.TabIndex = 21;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClasificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClasificacion.Location = new System.Drawing.Point(493, 63);
            this.lblClasificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(203, 33);
            this.lblClasificacion.TabIndex = 26;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDuracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDuracion.Location = new System.Drawing.Point(493, 178);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(149, 33);
            this.lblDuracion.TabIndex = 24;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdioma.Location = new System.Drawing.Point(13, 227);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(118, 33);
            this.lblIdioma.TabIndex = 22;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGenero.Location = new System.Drawing.Point(13, 144);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(127, 33);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "Genero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(13, 56);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 33);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Titulo:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 99);
            this.panel3.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas";
            // 
            // cboDirector
            // 
            this.cboDirector.FormattingEnabled = true;
            this.cboDirector.Location = new System.Drawing.Point(636, 120);
            this.cboDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDirector.Name = "cboDirector";
            this.cboDirector.Size = new System.Drawing.Size(218, 28);
            this.cboDirector.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(493, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Director:";
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(995, 595);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeliculas";
            this.Text = "FrmPeliculas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboDirector;
        private System.Windows.Forms.Label label2;
    }
}