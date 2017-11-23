using Controlador;
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
    public partial class ModificarUsuario : Form
    {

        UsuarioBL logNegUsu;
        RolBL logNegRol;
        Usuario us;

        public ModificarUsuario(Usuario user)
        {

            InitializeComponent();

            logNegUsu = new UsuarioBL();
            logNegRol = new RolBL();

            txtID.Text = user.Id;
            txtContra.Text = user.Contraseña;
            cbxRol.Text = user.getRol();

            us = new Usuario();
            us = user;

            BindingList<RolUsuario> listaRol = new BindingList<RolUsuario>();
            listaRol = logNegRol.listaRoles();
            cbxRol.ValueMember = "Descriptor";
            foreach (RolUsuario r in listaRol)
            {
                cbxRol.Items.Add(r);
            }

            //btnEditar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            string contras;
            int rol;

            if (txtContra.Text == "") contras = "NULL";
            else contras = txtContra.Text;

            try
            {
                if (logNegUsu.modificarUsuario(contras,cbxRol.Text,us.Id))
                    MessageBox.Show("El registro del usuario fue exitoso", "Mensaje de éxito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void verifyID_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "")
            {
                BindingList<Usuario> usuarios = new BindingList<Usuario>();
                usuarios = logNegUsu.listaUsuarios();
                bool noEncontrado = true;
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].Id == txtID.Text)
                    {
                        MessageBox.Show("Este Id no esta disponible", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        noEncontrado = false;
                        break;
                    }

                }

                if (noEncontrado)
                {
                    MessageBox.Show("Puede actualizar con este Id", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEditar.Enabled = true;
                }
            }

            else
            {
                MessageBox.Show("Puede actualizar con este Id", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEditar.Enabled = true;
            }
            

            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
