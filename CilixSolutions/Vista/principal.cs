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
        public principal()
        {
            InitializeComponent();
        }

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
    }
}
