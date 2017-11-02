using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Controlador;
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
            return pjDA.registrarPerJuridica(c);
        }

        public BindingList<PersonaJuridica> listaPJs()
        {
            return pjDA.devolverLista();
        }
    }
}
