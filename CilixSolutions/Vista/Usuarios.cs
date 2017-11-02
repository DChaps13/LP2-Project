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
        BindingList<Usuario> usuarios;
        UsuarioBL logNegUsu;
        RolBL logNegRol;
        EstadoBL logNegEstado;

        public Usuarios()
        {
            InitializeComponent();
            
            logNegUsu = new UsuarioBL();
            logNegRol = new RolBL();
            logNegEstado = new EstadoBL();

            BindingList<RolUsuario> listaRol = new BindingList<RolUsuario>();
            listaRol = logNegRol.listaRoles();
            cbxRol.ValueMember = "Descriptor";
            foreach (RolUsuario r in listaRol)
            {
                cbxRol.Items.Add(r);
            }

            BindingList<Estado> listaEst = new BindingList<Estado>();
            listaEst = logNegEstado.listarEstados();
            cbxEstado.ValueMember = "Nombre";
            foreach (Estado r in listaEst)
            {
                cbxEstado.Items.Add(r);
            }

            usuarios = logNegUsu.listaUsuarios();
            dataUsuarios.AutoGenerateColumns = false;
            dataUsuarios.DataSource = logNegUsu.listaUsuarios();
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

            BindingList<Usuario> usuariosSel = new BindingList<Usuario>();
            BindingList<Usuario> usuariosAux = new BindingList<Usuario>();

            if (textBox1.Text!= "Todos")
            {
                for (int i=0; i< usuarios.Count;i++)
                {
                    if(usuarios[i].Id == textBox1.Text)
                    {
                        usuariosSel.Add(usuarios[i]);
                    } 
                }             

            }
            else
            {
                usuariosSel = usuarios;
            }

            usuariosAux = usuariosSel;
            if (cbxRol.Text!= "Todos") // Rol del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Rol.ToString() != cbxRol.Text)
                    {
                        usuariosAux.Remove(usuariosSel[i]);
                    }
                }
            }

            usuariosSel = usuariosAux;
            if (cbxEstado.Text != "Todos") //Estado del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Estado.ToString() != cbxEstado.Text)
                    {
                        usuariosAux.Remove(usuariosSel[i]);
                    }
                }
            }

            usuariosSel = usuariosAux;

            dataUsuarios.DataSource = usuariosSel;
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
