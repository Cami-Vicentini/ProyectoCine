namespace ProyectoCine.Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picMaxim = new System.Windows.Forms.PictureBox();
            this.picMinim = new System.Windows.Forms.PictureBox();
            this.picBoxOcultar = new System.Windows.Forms.PictureBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picBoxMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(345, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 58);
            this.label4.TabIndex = 88;
            this.label4.Text = "Cine (nombre?)";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(28, 138);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(317, 338);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 87;
            this.picLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.panelTop.Controls.Add(this.picCerrar);
            this.panelTop.Controls.Add(this.picMaxim);
            this.panelTop.Controls.Add(this.picMinim);
            this.panelTop.Location = new System.Drawing.Point(-109, -29);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1019, 81);
            this.panelTop.TabIndex = 85;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(893, 36);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 40);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 74;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picMaxim
            // 
            this.picMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaxim.Image = ((System.Drawing.Image)(resources.GetObject("picMaxim.Image")));
            this.picMaxim.Location = new System.Drawing.Point(829, 36);
            this.picMaxim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMaxim.Name = "picMaxim";
            this.picMaxim.Size = new System.Drawing.Size(34, 40);
            this.picMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaxim.TabIndex = 76;
            this.picMaxim.TabStop = false;
            // 
            // picMinim
            // 
            this.picMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinim.Image = ((System.Drawing.Image)(resources.GetObject("picMinim.Image")));
            this.picMinim.Location = new System.Drawing.Point(767, 36);
            this.picMinim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMinim.Name = "picMinim";
            this.picMinim.Size = new System.Drawing.Size(34, 40);
            this.picMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinim.TabIndex = 75;
            this.picMinim.TabStop = false;
            this.picMinim.Click += new System.EventHandler(this.picMinim_Click);
            // 
            // picBoxOcultar
            // 
            this.picBoxOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.picBoxOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOcultar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOcultar.Image")));
            this.picBoxOcultar.Location = new System.Drawing.Point(700, 283);
            this.picBoxOcultar.Name = "picBoxOcultar";
            this.picBoxOcultar.Size = new System.Drawing.Size(72, 72);
            this.picBoxOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOcultar.TabIndex = 84;
            this.picBoxOcultar.TabStop = false;
            this.picBoxOcultar.Click += new System.EventHandler(this.picBoxOcultar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(459, 270);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(184, 33);
            this.lblContraseña.TabIndex = 83;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(465, 311);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(230, 26);
            this.txtContraseña.TabIndex = 82;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(465, 198);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 26);
            this.txtUsuario.TabIndex = 81;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(459, 148);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(132, 33);
            this.lblUsuario.TabIndex = 80;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(92)))), ((int)(((byte)(95)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogin.Location = new System.Drawing.Point(465, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(214, 76);
            this.btnLogin.TabIndex = 86;
            this.btnLogin.Text = "Iniciar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picBoxMostrar
            // 
            this.picBoxMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.picBoxMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMostrar.Image")));
            this.picBoxMostrar.Location = new System.Drawing.Point(700, 283);
            this.picBoxMostrar.Name = "picBoxMostrar";
            this.picBoxMostrar.Size = new System.Drawing.Size(72, 72);
            this.picBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMostrar.TabIndex = 89;
            this.picBoxMostrar.TabStop = false;
            this.picBoxMostrar.Click += new System.EventHandler(this.picBoxMostrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(831, 527);
            this.Controls.Add(this.picBoxMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.picBoxOcultar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMaxim;
        private System.Windows.Forms.PictureBox picMinim;
        private System.Windows.Forms.PictureBox picBoxOcultar;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picBoxMostrar;
    }
}