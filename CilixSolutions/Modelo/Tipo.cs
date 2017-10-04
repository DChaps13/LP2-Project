using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tipo
    {
        private string descriptor; /*nombre del tipo: Prestamo, venta, ajuste (+), ajuste (-)*/
        private string signo; /*Se agrega o se quita del stock*/

        public Tipo()
        {

        }

        public string Descriptor { get => descriptor; set => descriptor = value; }
        public string Signo { get => signo; set => signo = value; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
