using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RolUsuario
    {
        private int _id;
        private string descriptor;
        private int privilegio;

        public RolUsuario()
        {
        }

        public RolUsuario(int id, string descriptor, int privilegio)
        {
            this.Id = id;
            this.descriptor = descriptor;
            this.privilegio = privilegio;
        }

        public string Descriptor { get => descriptor; set => descriptor = value; }
        public int Privilegio { get => privilegio; set => privilegio = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
