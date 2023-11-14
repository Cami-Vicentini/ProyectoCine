namespace ProyectoCine.Vistas
{
    partial class FrmFunciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSelecPelicula = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantPeliculas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeliculas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(320, 148);
            this.cboPeliculas.Margin = new System.Windows.Forms.Padding(2);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(191, 36);
            this.cboPeliculas.TabIndex = 1;
            this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.cboPeliculas_SelectedIndexChanged);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.AllowUserToResizeColumns = false;
            this.dgvFunciones.AllowUserToResizeRows = false;
            this.dgvFunciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvFunciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFunciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvFunciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTitulo,
            this.ColSala,
            this.ColTipoSala,
            this.ColDia,
            this.ColHora,
            this.ColAcciones});
            this.dgvFunciones.Location = new System.Drawing.Point(0, 201);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvFunciones.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunciones.RowTemplate.Height = 24;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(1157, 358);
            this.dgvFunciones.TabIndex = 3;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 300;
            // 
            // ColSala
            // 
            this.ColSala.HeaderText = "Sala Nro";
            this.ColSala.MinimumWidth = 6;
            this.ColSala.Name = "ColSala";
            this.ColSala.ReadOnly = true;
            this.ColSala.Width = 150;
            // 
            // ColTipoSala
            // 
            this.ColTipoSala.HeaderText = "Formato";
            this.ColTipoSala.MinimumWidth = 6;
            this.ColTipoSala.Name = "ColTipoSala";
            this.ColTipoSala.ReadOnly = true;
            this.ColTipoSala.Width = 150;
            // 
            // ColDia
            // 
            this.ColDia.HeaderText = "Dia";
            this.ColDia.MinimumWidth = 6;
            this.ColDia.Name = "ColDia";
            this.ColDia.ReadOnly = true;
            this.ColDia.Width = 150;
            // 
            // ColHora
            // 
            this.ColHora.HeaderText = "Hora";
            this.ColHora.MinimumWidth = 6;
            this.ColHora.Name = "ColHora";
            this.ColHora.ReadOnly = true;
            this.ColHora.Width = 150;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 200;
            // 
            // lblSelecPelicula
            // 
            this.lblSelecPelicula.AutoSize = true;
            this.lblSelecPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecPelicula.ForeColor = System.Drawing.Color.Black;
            this.lblSelecPelicula.Location = new System.Drawing.Point(12, 152);
            this.lblSelecPelicula.Name = "lblSelecPelicula";
            this.lblSelecPelicula.Size = new System.Drawing.Size(294, 32);
            this.lblSelecPelicula.TabIndex = 6;
            this.lblSelecPelicula.Text = "Seleccione una película: ";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.Black;
            this.nudCantidad.Location = new System.Drawing.Point(835, 139);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(51, 45);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantPeliculas
            // 
            this.lblCantPeliculas.AutoSize = true;
            this.lblCantPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.lblCantPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPeliculas.ForeColor = System.Drawing.Color.Black;
            this.lblCantPeliculas.Location = new System.Drawing.Point(542, 152);
            this.lblCantPeliculas.Name = "lblCantPeliculas";
            this.lblCantPeliculas.Size = new System.Drawing.Size(271, 32);
            this.lblCantPeliculas.TabIndex = 8;
            this.lblCantPeliculas.Text = "Cantidad de Entradas: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 99);
            this.panel2.TabIndex = 77;
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
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funciones";
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1063, 14);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 40);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 78;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // FrmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1119, 557);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCantPeliculas);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblSelecPelicula);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.cboPeliculas);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.FrmFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.Label lblSelecPelicula;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantPeliculas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}