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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(391, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(64, 67);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(321, 24);
            this.cboPeliculas.TabIndex = 1;
            this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.cboPeliculas_SelectedIndexChanged);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTitulo,
            this.ColSala,
            this.ColTipoSala,
            this.ColDia,
            this.ColHora,
            this.ColAcciones});
            this.dgvFunciones.Location = new System.Drawing.Point(12, 131);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.RowTemplate.Height = 24;
            this.dgvFunciones.Size = new System.Drawing.Size(1048, 248);
            this.dgvFunciones.TabIndex = 3;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
            this.dgvFunciones.Click += new System.EventHandler(this.dgvFunciones_Click);
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 125;
            // 
            // ColSala
            // 
            this.ColSala.HeaderText = "Sala Nro";
            this.ColSala.MinimumWidth = 6;
            this.ColSala.Name = "ColSala";
            this.ColSala.ReadOnly = true;
            this.ColSala.Width = 125;
            // 
            // ColTipoSala
            // 
            this.ColTipoSala.HeaderText = "Formato";
            this.ColTipoSala.MinimumWidth = 6;
            this.ColTipoSala.Name = "ColTipoSala";
            this.ColTipoSala.ReadOnly = true;
            this.ColTipoSala.Width = 125;
            // 
            // ColDia
            // 
            this.ColDia.HeaderText = "Dia";
            this.ColDia.MinimumWidth = 6;
            this.ColDia.Name = "ColDia";
            this.ColDia.ReadOnly = true;
            this.ColDia.Width = 125;
            // 
            // ColHora
            // 
            this.ColHora.HeaderText = "Hora";
            this.ColHora.MinimumWidth = 6;
            this.ColHora.Name = "ColHora";
            this.ColHora.ReadOnly = true;
            this.ColHora.Width = 125;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 125;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(524, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // FrmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 724);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.cboPeliculas);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmFunciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}