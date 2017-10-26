using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Contacto
    {
        private int id_contacto;
        private string tipo_contacto;

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public string Tipo_contacto { get => tipo_contacto; set => tipo_contacto = value; }
    }
}
