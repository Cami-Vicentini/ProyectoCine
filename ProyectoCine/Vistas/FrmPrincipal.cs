using ProyectoCine.Datos.Implementacion;
using ProyectoCine.Datos.Interfaz;
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
    public partial class FrmPrincipal : Form
    {
        IFuncionDao servicio = null;
        public FrmPrincipal()
        {
            InitializeComponent();
            servicio = new FuncionDao();
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            cboPeliculas.DataSource = servicio.GetPeliculas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Funcion> lFunciones = servicio.GetFunciones((Pelicula)cboPeliculas.Items[cboPeliculas.SelectedIndex]);

            dgvFunciones.Rows.Clear();
            foreach (Funcion f in lFunciones)
            {
                dgvFunciones.Rows.Add(new object[] { f.oPelicula.Titulo, f.oSala.IdSala, f.oSala.TipoSala, f.Dia, f.Hora, "Comprar" });
            }
        }

        private void dgvFunciones_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.CurrentCell.ColumnIndex == 5)
            {
                int id_sala = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells["ColSala"].Value);
                FrmButacas frmButacas = new FrmButacas(id_sala);
                frmButacas.ShowDialog();

            }
        }
    }
}
