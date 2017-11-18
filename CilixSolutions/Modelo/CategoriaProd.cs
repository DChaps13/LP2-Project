using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CategoriaProd
    {
        private int _id;
        private string nombre;

        public CategoriaProd()
        {

        }

        public CategoriaProd(int id,string nombre)
        {
            this.Id = id;
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
