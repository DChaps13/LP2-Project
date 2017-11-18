using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace Controlador
{
    public class ProductoBL
    {
        private ProductoDA prodDA;

        public ProductoBL()
        {
            prodDA = new ProductoDA();
        }

        public bool registrarProducto(String proveedor, Producto p)
        {
            return prodDA.registrarProducto(proveedor, p);
        }

        public BindingList<Producto> listaProductos(String nombre, String categoria, String proveedor)
        {
            return prodDA.devolverLista(nombre, categoria, proveedor);
        }
    }
}