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
        public Transaccion()
        {
            InitializeComponent();
        }

        private void btBuscaContacto_Click(object sender, EventArgs e)
        {
            Proveedores frmBuscaContacto = new Proveedores();
            frmBuscaContacto.Owner = this;
            frmBuscaContacto.Visible = true;
        }

        private void btBuscaProd_Click(object sender, EventArgs e)
        {
            Productos frmBuscaProductos = new Productos();
            frmBuscaProductos.Owner = this;
            frmBuscaProductos.Visible = true;
        }

        private void btBuscaUsuario_Click(object sender, EventArgs e)
        {
            Usuarios frmBuscaUsuarios = new Usuarios();
            frmBuscaUsuarios.Owner = this;
            frmBuscaUsuarios.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevaTransaccion frmNuevaTransaccion = new NuevaTransaccion();
            frmNuevaTransaccion.Owner = this;
            frmNuevaTransaccion.Visible = true;
        }
    }
}
