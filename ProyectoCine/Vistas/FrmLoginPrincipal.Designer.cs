namespace ProyectoCine
{
    partial class FrmLoginPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrarALaApp = new System.Windows.Forms.Button();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lklInicioSesion = new System.Windows.Forms.LinkLabel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picCerrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEntrarALaApp);
            this.panel1.Controls.Add(this.lblInicioSesion);
            this.panel1.Controls.Add(this.lklInicioSesion);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Location = new System.Drawing.Point(38, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 395);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrarALaApp
            // 
            this.btnEntrarALaApp.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarALaApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarALaApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.btnEntrarALaApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEntrarALaApp.Location = new System.Drawing.Point(187, 187);
            this.btnEntrarALaApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEntrarALaApp.Name = "btnEntrarALaApp";
            this.btnEntrarALaApp.Size = new System.Drawing.Size(160, 64);
            this.btnEntrarALaApp.TabIndex = 9;
            this.btnEntrarALaApp.Text = "Ingresar";
            this.btnEntrarALaApp.UseVisualStyleBackColor = false;
            this.btnEntrarALaApp.Click += new System.EventHandler(this.btnEntrarALaApp_Click);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInicioSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInicioSesion.Location = new System.Drawing.Point(99, 288);
            this.lblInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(342, 33);
            this.lblInicioSesion.TabIndex = 7;
            this.lblInicioSesion.Text = "¿Ya tienes una cuenta?";
            // 
            // lklInicioSesion
            // 
            this.lklInicioSesion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.lklInicioSesion.AutoSize = true;
            this.lklInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lklInicioSesion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.lklInicioSesion.Location = new System.Drawing.Point(168, 340);
            this.lklInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklInicioSesion.Name = "lklInicioSesion";
            this.lklInicioSesion.Size = new System.Drawing.Size(205, 33);
            this.lklInicioSesion.TabIndex = 6;
            this.lklInicioSesion.TabStop = true;
            this.lklInicioSesion.Text = "Iniciar Sesión";
            this.lklInicioSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklInicioSesion_LinkClicked);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(204, 20);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(132, 58);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "Cine";
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(93)))));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(480, 0);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(68, 55);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 75;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // FrmLoginPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(617, 440);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEntrarALaApp;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.LinkLabel lklInicioSesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}