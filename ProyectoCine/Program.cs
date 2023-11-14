using ProyectoCine.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCine
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLoginPrincipal());

            FrmLoginPrincipal main = new FrmLoginPrincipal();
            //main.FormClosed += MainForm_Closed; //Esto hay que añadirlo para que cuando no haya nada abierto se cierre
            main.Show();
            Application.Run(/*new MenuPrincipal()*/); //Se tenia que comentar porque si no se cierra el programa cuando se abre el otro form   
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;
            if (Application.OpenForms.Count == 0)
                Application.ExitThread();
            else
                Application.OpenForms[0].FormClosed += MainForm_Closed;
        }
    }
}
