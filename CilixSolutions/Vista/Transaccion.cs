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
    public partial class Transaccion : Form
    {
        BindingList<Producto> listaProductos;
        BindingList<Usuario> listaUsuarios;
        BindingList<Contacto> listaContactos;

        public Transaccion()
        {
            InitializeComponent();
            listaProductos = new BindingList<Producto>();
            listaUsuarios = new BindingList<Usuario>();
            listaContactos = new BindingList<Contacto>();

            dgvUsuariosFilt.AutoGenerateColumns = false;

            dgvContactosFilt.DataSource = listaContactos;
            dgvProductosFilt.DataSource = listaProductos;
            dgvUsuariosFilt.DataSource = listaUsuarios;
        }

        private void btBuscaContacto_Click(object sender, EventArgs e)
        {
            Proveedores frmBuscaContacto = new Proveedores();
            //frmBuscaContacto.Owner = this;
            //frmBuscaContacto.Visible = true;
            if (frmBuscaContacto.ShowDialog() == DialogResult.OK)
            {
                listaContactos.Add(frmBuscaContacto.ContactoSeleccionado);
            }
        }

        private void btBuscaProd_Click(object sender, EventArgs e)
        {
            Productos frmBuscaProductos = new Productos();
            //frmBuscaProductos.Owner = this;
            //frmBuscaProductos.Visible = true;
            if(frmBuscaProductos.ShowDialog()== DialogResult.OK)
            {
                listaProductos.Add(frmBuscaProductos.ProductoSeleccionado);
            }
        }

        private void btBuscaUsuario_Click(object sender, EventArgs e)
        {
            Usuarios frmBuscaUsuarios = new Usuarios();
            //frmBuscaUsuarios.Owner = this;
            //frmBuscaUsuarios.Visible = true;
            if (frmBuscaUsuarios.ShowDialog() == DialogResult.OK)
            {
                listaUsuarios.Add(frmBuscaUsuarios.UsuarioSeleccionado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevaTransaccion frmNuevaTransaccion = new NuevaTransaccion();
            frmNuevaTransaccion.Owner = this;
            frmNuevaTransaccion.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
