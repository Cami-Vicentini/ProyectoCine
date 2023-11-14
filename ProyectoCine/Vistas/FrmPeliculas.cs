using ProyectoCine.Datos.Interfaz;
using ProyectoCine.Servicios;
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
    public partial class FrmPeliculas : Form
    {
        private string[] genero = { "Terror", "Accion", "Comedia", "Suspenso", "Ciencia Ficcion", "Drama" };
        private string[] idioma = { "Ingles", "Español", "Subtitulada", "Chino" };
        private string[] clasificacion = { "+13", "+15", "APT" };
        private string[] sala = { "1", "2", "3", "4" };
        IServicio servicio = null;
        Funcion nueva = null;
        public FrmPeliculas()
        {
            InitializeComponent();
            //servicio = new Servicios();
            nueva = new Funcion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            cboGenero.Items.AddRange(genero);
            cboIdioma.Items.AddRange(idioma);
            cboClasificacion.Items.AddRange(clasificacion);
            nudDuracion.Value = 0;
            cboSala.Items.AddRange(sala);
            dtpDia.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {   //Validar Datos
                GrabarPelicula(); //Confirmar y grabar
            }
        }

        private void GrabarPelicula()
        {
            nueva.oPelicula.Titulo = txtTitulo.Text;
            nueva.oPelicula.Genero = cboGenero.DisplayMember.ToString();
            nueva.oPelicula.Idioma = cboIdioma.DisplayMember.ToString();
            nueva.oPelicula.Clasificacion = cboClasificacion.DisplayMember.ToString();
            nueva.oPelicula.Duracion = (int)nudDuracion.Value;
            //nueva.Sala = Convert.ToInt32(cboSala.ValueMember + 1);
            //nueva.Dia = dtpDia.Value;
            //nueva.Hora = dtpHora.Value;
            if (servicio.CrearFuncion(nueva))
            {
                MessageBox.Show("Se registró con éxito la función", "Informe", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar el titulo de la pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un genero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un idioma", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una clasificacion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (nudDuracion.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una duracion valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sala ", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dtpDia.Value < DateTime.Today)
            {
                MessageBox.Show("Debe ingresar una fecha valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
