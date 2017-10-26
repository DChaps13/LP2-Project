using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PersonaNatural : Contacto
    {
        private string nombres;
        private string apellidoPat;
        private string apellidoMat;
        private string dni;
        private string telefono;
        private string correo;

        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPat { get => apellidoPat; set => apellidoPat = value; }
        public string ApellidoMat { get => apellidoMat; set => apellidoMat = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
