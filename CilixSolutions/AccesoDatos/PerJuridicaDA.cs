using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;

namespace AccesoDatos
{
    public class PerJuridicaDA
    {
        public PerJuridicaDA()
        {

        }

        public bool registrarPJ(PersonaJuridica c)
        {
            return true;
        }

        public BindingList<PersonaJuridica> devolverLista()
        {
            BindingList<PersonaJuridica> pjs = new BindingList<PersonaJuridica>();
            return pjs;
        }
    }
}
