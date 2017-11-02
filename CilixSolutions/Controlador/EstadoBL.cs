using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using AccesoDatos;

namespace Controlador
{
    public class EstadoBL
    {
        private EstadoDA estadoDA;

        public EstadoBL()
        {
            estadoDA = new EstadoDA();
        }

        public BindingList<Estado> listarEstados()
        {
            return estadoDA.devolverLista();
        }
    }
}
