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
    
    public partial class FrmButacas : Form
    {
        private Funcion oFuncion;
        private IFuncionDao servicio;
        private Venta nuevaVenta;



        private List<Butaca> lButacasSelecc = new List<Butaca>();

        public FrmButacas(Funcion funcion)
        {
            InitializeComponent();
            servicio = new FuncionDao();
            nuevaVenta = new Venta();
            oFuncion = funcion;
        }

        private void CargarButacas()
        {
            OrdenarControles();

            oFuncion.oSala.lButacas = servicio.GetButacas(oFuncion);
            Butaca[] arrButacas = oFuncion.oSala.lButacas.ToArray();

            for (int i = 0; i < pButacas.Controls.Count; i++)
            {
                pButacas.Controls[i].Tag = arrButacas[i]; //Almacena una Butaca en el control
                pButacas.Controls[i].Text = arrButacas[i].FilaCol;
                if (arrButacas[i].Estado == Estado.Libre)
                {
                    pButacas.Controls[i].BackColor = Color.Lime;
                }
                else if (arrButacas[i].Estado == Estado.Ocupado)
                {
                    pButacas.Controls[i].Enabled = false;
                    pButacas.Controls[i].BackColor = Color.Red;
                }
                else
                {
                    pButacas.Controls[i].Enabled = false;
                    pButacas.Controls[i].BackColor = Color.Red;
                }
                pButacas.Controls[i].Click += Butaca_Color;
                pButacas.Controls[i].Click += SelecButacas_Click;

            }
        }


        private void SelecButacas_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Butaca butaca)
            {
                Entrada nuevaEntrada = new Entrada(butaca);
                if (nuevaVenta.AgregarEntrada(nuevaEntrada))
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                }
                else
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    nuevaVenta.QuitarEntrada(nuevaEntrada);
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                }
            }

        }

        private void Butaca_Color(object sender, EventArgs e)
        {
            Button botonSeleccionado = (Button)sender;
            if (botonSeleccionado.BackColor == Color.Yellow)
            {
                botonSeleccionado.BackColor = Color.Lime;
            }
            else
            {
                botonSeleccionado.BackColor = Color.Yellow;
            }

        }

        private void FrmButacas_Load(object sender, EventArgs e)
        {
            CargarButacas();
            this.Text += oFuncion.oSala.IdSala.ToString() + " | Butacas seleccionadas: ";
        }

        private void OrdenarControles()
        {
            List<Button> listaBotones = pButacas.Controls.OfType<Button>().ToList();
            listaBotones = listaBotones.OrderBy(b => int.Parse(b.Text)).ToList();
            pButacas.Controls.Clear();
            pButacas.Controls.AddRange(listaBotones.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
