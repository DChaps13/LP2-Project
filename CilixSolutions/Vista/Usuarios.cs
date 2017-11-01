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

        public Usuarios()
        {
            InitializeComponent();
            
            logNegUsu = new UsuarioBL();
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
            if (comboBox1.Text!= "Todos") // Rol del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Rol.ToString() != comboBox1.Text)
                    {
                        usuariosAux.Remove(usuariosSel[i]);
                    }
                }
            }

            usuariosSel = usuariosAux;
            if (comboBox2.Text != "Todos") //Estado del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Estado != comboBox2.Text)
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
    }
}
