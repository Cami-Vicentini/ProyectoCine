using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCine.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validar
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picBoxOcultar_Click(object sender, EventArgs e)
        {
            picBoxMostrar.BringToFront();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void picBoxMostrar_Click(object sender, EventArgs e)
        {
            picBoxOcultar.BringToFront();
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void picMinim_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
