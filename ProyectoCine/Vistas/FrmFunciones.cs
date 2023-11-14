using ProyectoCine.Datos.Implementacion;
using ProyectoCine.Datos.Interfaz;
using ProyectoCine.Entidades;
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
    public partial class FrmFunciones : Form
    {
       // private Venta nuevaVenta;
        private List<Funcion> lFunciones;
        private IFuncionDao servicio = null;
        public FrmFunciones()
        {
            InitializeComponent();
            servicio = new FuncionDao();
            lFunciones = new List<Funcion>();
        }

        private void CargarPeliculas()
        {
            cboPeliculas.DataSource = servicio.GetPeliculas();
            cboPeliculas.ValueMember = "IdPelicula";
            cboPeliculas.DisplayMember = "Titulo";
            cboPeliculas.SelectedValue = -1;
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunciones.CurrentCell.ColumnIndex == 5)
            {
                if (servicio.ButacasDisponibles(lFunciones[dgvFunciones.CurrentRow.Index], int.Parse(nudCantidad.Value.ToString())))
                {
                    FrmButacas frmButacas = new FrmButacas(lFunciones[dgvFunciones.CurrentRow.Index]);
                    frmButacas.ShowDialog();
                }
                else
                {
                    MessageBox.Show("la cantidad de entradas es inválida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudCantidad.Value = 1;
                }
            }
        }

        private void cboPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFunciones.Rows.Clear();
            if (cboPeliculas.SelectedIndex > -1)
            {
                lFunciones.Clear();
                lFunciones = servicio.GetFunciones((Pelicula)cboPeliculas.Items[cboPeliculas.SelectedIndex]);
                

                dgvFunciones.Rows.Clear();
                foreach (Funcion f in lFunciones)
                {
                    dgvFunciones.Rows.Add(new object[] { f.oPelicula.Titulo, f.oSala.IdSala, f.oSala.TipoSala, f.Dia, f.Hora, "Comprar" });
                }
                dgvFunciones.ClearSelection();
            }
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
