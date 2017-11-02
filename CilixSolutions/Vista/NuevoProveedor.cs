using Modelo;
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

    public partial class NuevoProveedor : Form
    {
        private PersonaJuridica proveedor;
        public NuevoProveedor()
        {
            InitializeComponent();
            proveedor = new PersonaJuridica();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string razon;
            razon = textBox1.Text;
            string ruc;
            ruc = textBox1.Text;
            string telefono;
            telefono = textBox1.Text;
            string correo;
            correo = textBox1.Text; 
            bool esCliente;
            if (rbSi.Checked)
            {
                esCliente = true;

                proveedor.EsCliente = esCliente;
            }
            if(rbNo.Checked)
            {
                esCliente = false;

                proveedor.EsCliente = esCliente;
            }
            proveedor.RazonSocial = razon;
            proveedor.Ruc = ruc;
            proveedor.Telefono = telefono;
            proveedor.Correo = correo;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
