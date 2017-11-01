using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace AccesoDatos
{
    public class UsuarioDA
    {
        public UsuarioDA()
        {

        }

        public bool registrarUsuario(Usuario u)
        {
            return true;
        }

        public BindingList<Usuario> devolverLista()
        {
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            return usuarios;
        }
    }
}
