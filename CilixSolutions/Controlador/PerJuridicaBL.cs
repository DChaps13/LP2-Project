using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

namespace Controlador
{
    public class PerJuridicaBL
    {
        private PerJuridicaDA pjDA;

        public PerJuridicaBL()
        {
            pjDA = new PerJuridicaDA();
        }

        public bool registrarPerJuridica(PersonaJuridica c)
        {
            return pjDA.registrarPJ(c);
        }

        public BindingList<PersonaJuridica> listaPJs()
        {
            return pjDA.devolverLista();
        }

        public BindingList<PersonaJuridica> listarProveedores()
        {
            return pjDA.devolverProveedores();
        }

        public BindingList<PersonaJuridica> buscaProveedor(string razonSocial,string ruc)
        {
            return pjDA.buscarProveedor(razonSocial, ruc);
        }
    }
}
