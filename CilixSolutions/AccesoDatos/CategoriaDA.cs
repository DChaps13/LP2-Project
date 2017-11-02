using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;

namespace AccesoDatos
{
    public class CategoriaDA
    {
        public CategoriaDA()
        {

        }

        public bool registrarCategoria(CategoriaProd c)
        {
            return true;
        }

        public BindingList<CategoriaProd> devolverLista()
        {
            BindingList<CategoriaProd> categorias = new BindingList<CategoriaProd>();
            return categorias;
        }
    }
}
