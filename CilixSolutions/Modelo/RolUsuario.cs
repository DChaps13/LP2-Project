using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RolUsuario
    {
        private string descriptor;
        private int privilegio;

        public string Descriptor { get => descriptor; set => descriptor = value; }
        public int Privilegio { get => privilegio; set => privilegio = value; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
