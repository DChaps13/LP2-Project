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
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
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
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Acceso DENEGADO. Contraseña incorrecta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
