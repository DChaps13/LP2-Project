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
                TipoTransaccion t = new TipoTransaccion();
                t.Descriptor = linea;
                t.Signo =Int32.Parse(lectorTipos.ReadLine());
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

        private void txtNombUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblNombUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIDProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
