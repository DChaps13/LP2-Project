using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PersonaJuridica : Contacto
    {
        private string razonSocial;
        private string ruc;
        private string telefono;
        private string correo;

        public PersonaJuridica()
        {

        }

        private bool esCliente; //corresponde al comentario en el diagrama de clases

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public bool EsCliente { get => esCliente; set => esCliente = value; }
    }
}
