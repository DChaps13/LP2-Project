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
    public class RolBL
    {
        private RolDA rolDA;

        public RolBL()
        {
            rolDA = new RolDA();
        }

        public bool registrarRol(RolUsuario r)
        {
            return rolDA.registrarRol(r);
        }

        public BindingList<RolUsuario> listaRoles()
        {
            return rolDA.devolverLista();
        }
    }
}
