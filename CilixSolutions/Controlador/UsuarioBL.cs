using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace Controlador
{
    public class UsuarioBL
    {
        private UsuarioDA usuarioDA;

        public UsuarioBL()
        {
            usuarioDA = new UsuarioDA();
        }

        public bool registrarUsuario(Usuario u)
        {
            return usuarioDA.registrarUsuario(u);
        }

        public BindingList<Usuario> listaUsuarios()
        {
            return usuarioDA.devolverLista();
        }





    }
}
