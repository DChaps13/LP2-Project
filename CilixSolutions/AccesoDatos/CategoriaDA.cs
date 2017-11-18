using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.Data.SqlClient;


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

            ConexionBD cadConexion = new ConexionBD();
            
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.buscarCategoria";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();


            while (reader.Read())
            {
                CategoriaProd cat = new CategoriaProd(Int32.Parse(reader["Id"].ToString()), reader["Nombre"].ToString());
                categorias.Add(cat);
            }

            conexion.Close();

            return categorias;
        }
    }
}
