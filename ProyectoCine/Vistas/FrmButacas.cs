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
    
    public partial class FrmButacas : Form
    {

        private Button botonSeleccionado = null;
        private IFuncionDao servicio;
        private int idSala;
        public FrmButacas(int sala)
        {
            InitializeComponent();
            servicio = new FuncionDao();
            idSala = sala;
            CargarButacas();
        }

        private void CargarButacas()
        {
            List<Butaca> lButacas = new List<Butaca>();
            lButacas = servicio.GetButacas(idSala);
            foreach (Butaca b in lButacas)
            {
                dgvButacas.Rows.Add(new object[] { b.NroButaca, b.Estado });
            }

            Butaca[] arrButacas = lButacas.ToArray();

            for (int i = 0; i < pButacas.Controls.Count; i++)
            {
                pButacas.Controls[i].Text = arrButacas[i].ToString();
                if (arrButacas[i].Estado == Estado.Libre)
                {
                    pButacas.Controls[i].BackColor = Color.Green;
                }
                pButacas.Controls[i].Click += FrmButacas_Click;

            }
        }

        private void FrmButacas_Click(object sender, EventArgs e)
        {
            botonSeleccionado = (Button)sender;
            if (botonSeleccionado.BackColor == Color.Yellow)
            {
                botonSeleccionado.BackColor = Color.Green;
            }
            else
            {
                botonSeleccionado.BackColor = Color.Yellow;
            }
            
        }
    }
}
