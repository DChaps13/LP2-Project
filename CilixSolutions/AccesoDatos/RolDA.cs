using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;

namespace AccesoDatos
{
    public class RolDA
    {
        public RolDA()
        {

        }

        public bool registrarRol(RolUsuario r)
        {
            return true;
        }

        public BindingList<RolUsuario> devolverLista()
        {
            BindingList<RolUsuario> roles = new BindingList<RolUsuario>();
            return roles;
        }
    }
}
