using ProyectoCine.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCine
{
    public partial class FrmLoginPrincipal : Form
    {
        public FrmLoginPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrarALaApp_Click(object sender, EventArgs e)
        {
           
            FrmLogin menu = new FrmLogin();
            menu.Show();
            //this.Close();
        }

        private void lklInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            FrmLogin menu = new FrmLogin();
            menu.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
