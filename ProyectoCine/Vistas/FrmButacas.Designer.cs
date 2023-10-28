namespace ProyectoCine.Vistas
{
    partial class FrmButacas
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
            this.dgvButacas = new System.Windows.Forms.DataGridView();
            this.ColNroButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvButacas
            // 
            this.dgvButacas.AllowUserToAddRows = false;
            this.dgvButacas.AllowUserToDeleteRows = false;
            this.dgvButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNroButaca,
            this.ColEstado});
            this.dgvButacas.Location = new System.Drawing.Point(54, 85);
            this.dgvButacas.Name = "dgvButacas";
            this.dgvButacas.ReadOnly = true;
            this.dgvButacas.RowHeadersWidth = 51;
            this.dgvButacas.RowTemplate.Height = 24;
            this.dgvButacas.Size = new System.Drawing.Size(801, 416);
            this.dgvButacas.TabIndex = 0;
            // 
            // ColNroButaca
            // 
            this.ColNroButaca.HeaderText = "NroButaca";
            this.ColNroButaca.MinimumWidth = 6;
            this.ColNroButaca.Name = "ColNroButaca";
            this.ColNroButaca.ReadOnly = true;
            this.ColNroButaca.Width = 125;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.MinimumWidth = 6;
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 125;
            // 
            // FrmButacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 632);
            this.Controls.Add(this.dgvButacas);
            this.Name = "FrmButacas";
            this.Text = "FrmButacas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
    }
}