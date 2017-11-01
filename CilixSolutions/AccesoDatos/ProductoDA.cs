using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;

namespace AccesoDatos
{
    public class ProductoDA
    {
        public ProductoDA()
        {

        }

        public bool registrarProducto(Producto p)
        {
            return true;
        }

        public BindingList<Producto> devolverLista()
        {
            BindingList<Producto> productos = new BindingList<Producto>();
            return productos;
        }
    }
}
