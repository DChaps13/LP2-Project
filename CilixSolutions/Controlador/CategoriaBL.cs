using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

namespace Controlador
{
    public class CategoriaBL
    {
        private CategoriaDA catDA;

        public CategoriaBL()
        {
            catDA = new CategoriaDA();
        }

        public bool registrarCategoria(CategoriaProd c)
        {
            return catDA.registrarCategoria(c);
        }

        public BindingList<CategoriaProd> listaCategorias()
        {
            return catDA.devolverLista();
        }
    }
}
