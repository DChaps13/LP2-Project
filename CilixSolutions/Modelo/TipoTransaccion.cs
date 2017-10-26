using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoTransaccion
    {
        private string descriptor; /*nombre del tipo: Prestamo, venta, ajuste (+), ajuste (-)*/
        private int signo; /*Se agrega o se quita del stock*/

        public TipoTransaccion()
        {

        }

        public string Descriptor { get => descriptor; set => descriptor = value; }
        public int Signo { get => signo; set => signo = value; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
