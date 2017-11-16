using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PersonaJuridica : Contacto
    {
        private int _id;
        private string razonSocial;
        private string ruc;
        private string telefono;
        private string correo;

        public PersonaJuridica()
        {

        }

        public PersonaJuridica(string razonSocial, string ruc, string telefono, string correo)
        {
            //this.Id = id;
            this.razonSocial = razonSocial;
            this.ruc = ruc;
            this.telefono = telefono;
            this.correo = correo;
        }

        private bool esCliente; //corresponde al comentario en el diagrama de clases

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public bool EsCliente { get => esCliente; set => esCliente = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
