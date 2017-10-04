using Modelo;
using System;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class NuevaTransaccion : Form
    {
        public NuevaTransaccion()
        {
            InitializeComponent();
            //por ejemplo. Luego pasarlo a Data Access y Control

            string ruta = "..//..//..//tipos.txt";
            FileStream archivoTipos = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lectorTipos = new StreamReader(archivoTipos);
            while (true)
            {
                string linea = lectorTipos.ReadLine();
                if (linea == null) break;
                Tipo t = new Tipo();
                t.Descriptor = linea;
                t.Signo = lectorTipos.ReadLine();
                cboTipo.Items.Add(t);
            }
        }       

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btNuevoContacto_Click(object sender, EventArgs e)
        {
            NuevoProveedor frmNuevoContacto = new NuevoProveedor();
            frmNuevoContacto.Owner = this;
            frmNuevoContacto.Visible = true;
        }

        private void btBuscarContacto_Click(object sender, EventArgs e)
        {
            Proveedores frmContacto = new Proveedores();
            frmContacto.Owner = this;
            frmContacto.Visible = true;
        }

        private void btBuscaProducto_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.Owner = this;
            frmProductos.Visible = true;
        }
    }
}
