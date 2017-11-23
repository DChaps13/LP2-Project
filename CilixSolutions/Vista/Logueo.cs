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
using System.IO;
using System.Security.Cryptography;

namespace Vista
{
    public partial class Logueo : Form
    {

        bool seLogro;

        public Logueo()
        {
            InitializeComponent();
            seLogro = false;

        }

        private Usuario usuarioActivo;

        public Usuario UsuarioActivo { get => usuarioActivo; set => usuarioActivo = value; }

        private Usuario getUser(string usuario, string contrasena)
        {
            Usuario u = new Usuario();
            UsuarioBL logNegUs = new UsuarioBL();
            BindingList<Usuario> lstUsuarios = new BindingList<Usuario>();

            //operaciones SQL y asignación de datos a u;
            //debugeo

            while (true) {
                lstUsuarios = logNegUs.listaUsuarios();
                //lstUsuarios = logNegUs.buscarUsuarios(txtUsuario.Text, "Todos", "Todos");//"juan";
                if (lstUsuarios.Count >= 1)
                {
                    bool valid = false;
                    for (int i = 0; i < lstUsuarios.Count && !valid; ++i) {
                        Usuario x = lstUsuarios.ElementAt(i);
                        if (x.Id == usuario && x.Contraseña == contrasena)
                        {
                            return x;
                        }
                        if (x.Id == usuario && x.Contraseña == contrasena && x.Estado.Nombre== "Eliminado")
                        {
                            MessageBox.Show("USUARIO INACTIVO", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }
                    return null;
                }
                if (lstUsuarios.Count == 0)
                {
                    MessageBox.Show("USUARIO INVALIDO", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;

                }
            }
            
            u.Id = lstUsuarios[0].Id;
            u.Rol.Privilegio = lstUsuarios[0].Rol.Privilegio;
            u.Rol.Descriptor =lstUsuarios[0].Rol.Descriptor;
            //u.Rol.Privilegio = 1;
            //    u.Rol.Descriptor = "Administrador"; //pueden haber roles con el mismo privilegio y otros nombres e.g: Gerente (en caso se expanda el sistema)

            if (u.Id != null)
                return u;
            else return null;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            //Si se confirma que el usuario y contraseña se encuentran en la base de datos, devolver el usuario;
            usuarioActivo = getUser(txtUsuario.Text, txtContraseña.Text);
            if (usuarioActivo != null)
            {
                seLogro = true;
                DialogResult = DialogResult.OK;
                Cilix form = new Cilix(UsuarioActivo);
                this.Visible = false;
                form.Visible = false;
                form.ShowDialog();
                Close();
                
                
            }
            else {
                MessageBox.Show("Acceso DENEGADO. Usuario y/o Contraseña incorrecta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Logueo_Load(object sender, EventArgs e)
        {

        }

        private void Logueo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Logueo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!seLogro) {
                Cilix f = new Cilix();
                f.Visible = true;
            }
            
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
