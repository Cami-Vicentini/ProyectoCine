﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ProyectoCine.Vistas
{
    public partial class FrmMenu : Form
    {
        int cont = 0;
        int cont2 = 0;
        public FrmMenu()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            //ocultar paneles de submenú
            panelArchivo.Visible = false;
            panelSoporte.Visible = false;
            panelTransaccion.Visible = false;
            panelReportes.Visible = false;
            panelAcercaDe.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelSoporte.Visible == true)
                panelSoporte.Visible = false;
            if (panelTransaccion.Visible == true)
                panelTransaccion.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelAcercaDe.Visible == true)
                panelAcercaDe.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //archivos

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelArchivo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //unir formulario
            FrmMensaje mens = new FrmMensaje();
            mens.Show();
            OcultarSubMenu();
        }


        //soporte

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSoporte);
        }

        private void btnAbm_Click(object sender, EventArgs e)
        {
            //unir formulario

            OcultarSubMenu();
        }

        //transacciones

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelTransaccion);
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            
            FrmPeliculas pel = new FrmPeliculas();
            pel.Show();

            OcultarSubMenu();
        }

        //reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelReportes);
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            FrmFunciones fun = new FrmFunciones();
            fun.Show();

            OcultarSubMenu();
        }


        // acerca de..
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAcercaDe);

        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {

            FrmAcercaDe acer = new FrmAcercaDe();
            acer.Show();
            OcultarSubMenu();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del programa?", "Cerrar sesion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            cont++;
            cont2++;
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToString("dddd MMMM yyyy");
            if (cont == 600)
            {
                Pic.Visible = true;
            }
        }

   

        private void picMinim_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        //private void btnTransaccion_Click_1(object sender, EventArgs e)
        //{
        //    FrmPeliculas pel = new FrmPeliculas();
        //    pel.Show();
        //}
    }
}
