using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

using Controlador;
using Modelo;
namespace Vista
{
    public partial class NuevoUsuario : Form
    {
        UsuarioBL logNegUsu;
        RolBL logNegRol;

        public NuevoUsuario()
        {
            InitializeComponent();
            logNegUsu = new UsuarioBL();

            logNegRol = new RolBL();
            BindingList<RolUsuario> listaRol = new BindingList<RolUsuario>();
            listaRol = logNegRol.listaRoles();
            comboBox1.ValueMember = "Descriptor";
            foreach (RolUsuario r in listaRol)
            {
                comboBox1.Items.Add(r);
            }

            btnCrear.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //crear USUARIO
        {
            Usuario u = new Usuario();

            if (txtID.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCrear.Enabled = false;
                return;
            }

            if (txtContra.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtID.Text.Length > 20) //Maximo nro de caracteres
            {
                MessageBox.Show("Solo puede ingresar un máximo de 20 caracteres en el ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCrear.Enabled = false;
                return;
            }

            if (txtContra.Text.Length > 20)  //Maximo nro de caracteres
            {
                MessageBox.Show("Solo puede ingresar un máximo de 20 caracteres en la Contraseña", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            u.Id = txtID.Text; //id
            //u.Contraseña = encrypt(txtContra.Text); //contraseña
            u.Contraseña = encrypt(txtContra.Text);

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            u.Rol = (RolUsuario)comboBox1.SelectedItem;

            u.FechaCreacion = DateTime.Now;
            u.FechaModificacion = DateTime.Now;
            Estado est = new Estado();
            est.Id = 1;

            u.Estado = est;
            try
            {
                if(logNegUsu.registrarUsuario(u))
                    MessageBox.Show("El registro del usuario fue exitoso", "Mensaje de éxito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo crear el usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Cancelar Nuevo Usuario
        {
            this.Close();
        }

        private void verifyID_Click(object sender, EventArgs e)
        {
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            usuarios = logNegUsu.listaUsuarios();
            bool noEncontrado = true;
            for (int i=0; i< usuarios.Count; i++)
            {
                if(usuarios[i].Id == txtID.Text)
                {
                    MessageBox.Show("Este Id no esta disponible", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    noEncontrado = false;
                    break;
                }
                
            }

            if (noEncontrado)
            {
                MessageBox.Show("Puede registrarse con este Id", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCrear.Enabled = true;
            }
            return;


        }

        private string encrypt(string password)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }
    }
}
