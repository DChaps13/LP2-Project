﻿using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class principal : Form
    {
        private Usuario usuarioActual;

        public principal(Usuario usu)
        {
            this.usuarioActual = usu;
            InitializeComponent();

            this.Visible = true;
            lbLoggedUser.Font = new Font(lbLoggedUser.Font, FontStyle.Bold);
            lbLoggedUser.Text = "Hola, " + usuarioActual.Id + " (" + usuarioActual.Rol.Descriptor + ")";
            lbLoggedUser.Visible = true;

            logOutToolStripMenuItem.Visible = true;


            transaccionesToolStripMenuItem.Visible = true;
            transaccionesToolStripMenuItem.Enabled = true;
            logueoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = true;
            buscarToolStripMenuItem.Enabled = true;

            clientesToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem1.Visible = false;
            transacciónToolStripMenuItem.Visible = false;
            transacciónToolStripMenuItem1.Visible = false;

            switch (usuarioActual.Rol.Privilegio)
            {
                case (1): //Administrador

                    //Nuevo
                    transacciónToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = true;
                    naturalToolStripMenuItem.Enabled = true;
                    jurídicoToolStripMenuItem.Enabled = true;
                    productoToolStripMenuItem1.Enabled = true;
                    //Buscar
                    transacciónToolStripMenuItem1.Enabled = true;
                    usuarioToolStripMenuItem1.Enabled = true;
                    juridicoToolStripMenuItem1.Enabled = true; //natural
                    jurídicoToolStripMenuItem2.Enabled = true; //juridico
                    productoToolStripMenuItem.Enabled = true;

                    break;
                case (2): //Registrador
                          //Nuevo
                    transacciónToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = false;//<- restringido
                    naturalToolStripMenuItem.Enabled = true;
                    jurídicoToolStripMenuItem.Enabled = true;
                    productoToolStripMenuItem1.Enabled = true;
                    //Buscar
                    transacciónToolStripMenuItem1.Enabled = true;
                    usuarioToolStripMenuItem1.Enabled = true;
                    juridicoToolStripMenuItem1.Enabled = true; //natural
                    jurídicoToolStripMenuItem2.Enabled = true; //juridico
                    productoToolStripMenuItem.Enabled = true;
                    break;
                case (3): //Trabajador
                          //Nuevo
                    transacciónToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = false; //<- restringido
                    naturalToolStripMenuItem.Enabled = true;
                    jurídicoToolStripMenuItem.Enabled = true;
                    productoToolStripMenuItem1.Enabled = false; //<- restringido
                                                                //Buscar
                    transacciónToolStripMenuItem1.Enabled = true;
                    usuarioToolStripMenuItem1.Enabled = true;
                    juridicoToolStripMenuItem1.Enabled = true; //natural
                    jurídicoToolStripMenuItem2.Enabled = true; //juridico
                    productoToolStripMenuItem.Enabled = true;
                    break;
            }
        }


        //Eventos del form
        private void transacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaTransaccion childForm = new NuevaTransaccion();
            childForm.MdiParent = this;
            childForm.Text = "Nueva Transaccion";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void transacciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transaccion childForm = new Transaccion();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Transaccion";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario childForm = new NuevoUsuario();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Usuario";
            childForm.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios childForm = new Usuarios();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Usuarios";
            childForm.Show();
        }

        private void jurídicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProveedor childForm = new NuevoProveedor();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Proveedor";
            childForm.Show();
        }

        private void jurídicoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Proveedores childForm = new Proveedores();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Proveedores";
            childForm.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoProducto childForm = new NuevoProducto();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Producto";
            childForm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos childForm = new Productos();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Productos";
            childForm.Show();            
        }

        private void logueoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logueo childForm = new Logueo();
            this.Close();
            this.Visible = false;
            childForm.Visible = false;
            if (childForm.ShowDialog() == DialogResult.OK)
            {
                usuarioActual = childForm.UsuarioActivo;

                                
                
            }
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void naturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCliente childForm = new NuevoCliente();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Cliente";
            childForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioActual = null;

            lbLoggedUser.Font = new Font(lbLoggedUser.Font, FontStyle.Regular);
            lbLoggedUser.Visible = false;
            transaccionesToolStripMenuItem.Enabled = false;
            buscarToolStripMenuItem.Enabled = false;

            logueoToolStripMenuItem.Enabled = true;
            logueoToolStripMenuItem.Visible = true;
            logOutToolStripMenuItem.Visible = false;
            
            //Nuevo
            transacciónToolStripMenuItem.Enabled = false;
            usuarioToolStripMenuItem.Enabled = false;
            naturalToolStripMenuItem.Enabled = false;
            jurídicoToolStripMenuItem.Enabled = false;
            productoToolStripMenuItem1.Enabled = false;
            //Buscar
            transacciónToolStripMenuItem1.Enabled = false;
            usuarioToolStripMenuItem1.Enabled = false;
            juridicoToolStripMenuItem1.Enabled = false; //natural
            jurídicoToolStripMenuItem2.Enabled = false; //juridico
            productoToolStripMenuItem.Enabled = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void lbLoggedUser_Click(object sender, EventArgs e)
        {

        }

        private void juridicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
