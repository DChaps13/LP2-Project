using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        string _nombre;
        int _cantidad;
        double _precio;
        string _estado;
        string _categoria;

        public Producto(string nombre, int cantidad, double precio, string estado, string categoria)
        {
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
            _estado = estado;
            _categoria = categoria;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
