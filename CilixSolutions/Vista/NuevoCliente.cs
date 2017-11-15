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
    public partial class NuevoCliente : Form
    {
        private PersonaNatural cliente;
        public NuevoCliente()
        {
            InitializeComponent();
            cliente = new PersonaNatural();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NOMBREtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void APEPATtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void APEMATtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DNItextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CREARbutton_Click(object sender, EventArgs e)
        {
            string nombres;
            nombres = NOMBREtextBox.Text;
            string apellidoPat;
            apellidoPat = APEPATtextBox.Text;
            string apellidoMat;
            apellidoMat = APEMATtextBox.Text;
            string dni;
            dni = DNItextBox.Text;
            string telefono;
            telefono = TLFtextBox.Text;
            string correo;
            correo = CORREOtextBox.Text;


            cliente.Nombres = nombres;
            cliente.ApellidoPat = apellidoPat;
            cliente.ApellidoMat = apellidoMat;
            cliente.Correo = correo;
            cliente.Telefono = telefono;
            cliente.Dni = dni;




        }

        private void CANCELARbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
