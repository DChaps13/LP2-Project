﻿using System;
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

        public bool registrarRol(Producto p)
        {
            return prodDA.registrarProducto(p);
        }

        public BindingList<Producto> listaRoles()
        {
            return prodDA.devolverLista();
        }
    }
}
}
