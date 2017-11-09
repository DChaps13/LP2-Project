using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class Usuarios : Form
    {
        private BindingList<Usuario> usuarios;
        private UsuarioBL logNegUsu;
        
        public Usuarios()
        {
            InitializeComponent();

            logNegUsu = new UsuarioBL();
            RolBL logNegRol = new RolBL();
            EstadoBL logNegEstado = new EstadoBL();


            BindingList<RolUsuario> listaRol = new BindingList<RolUsuario>();
            listaRol = logNegRol.listaRoles();
            cbxRol.ValueMember = "Descriptor";
            cbxRol.Items.Add("Todos");
            foreach (RolUsuario r in listaRol)
            {
                cbxRol.Items.Add(r);
            }

            BindingList<Estado> listaEst = new BindingList<Estado>();
            listaEst = logNegEstado.listarEstados();
            cbxEstado.ValueMember = "Nombre";
            cbxEstado.Items.Add("Todos");
            foreach (Estado r in listaEst)
            {
                cbxEstado.Items.Add(r);
            }

            usuarios = new BindingList<Usuario>();
            //usuarios = logNegUsu.listaUsuarios();

            dataUsuarios.AutoGenerateColumns = false;
            dataUsuarios.Refresh();
            dataUsuarios.AllowUserToAddRows = false;
            //dataUsuarios.DataSource = usuarios;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        


        private void Buscar_Click(object sender, EventArgs e)
        {

            usuarios = logNegUsu.buscarUsuarios(textBox1.Text, cbxRol.Text, cbxEstado.Text);

            dataUsuarios.DataSource = usuarios;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario frmNuevoUsuario = new NuevoUsuario();
            if (frmNuevoUsuario.ShowDialog() == DialogResult.OK)
            {
                usuarios = logNegUsu.listaUsuarios();
                dataUsuarios.DataSource = usuarios;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
