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
    public class EstadoDA
    {

        public EstadoDA()
        {

        }


        public BindingList<Estado> devolverLista()
        {
            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT * FROM dbo.Estado";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();

            BindingList<Estado> lstEstado = new BindingList<Estado>();
            while (reader.Read())
            {
                Estado estado = new Estado(Int32.Parse(reader["Id"].ToString()), reader["Nombre"].ToString());
                lstEstado.Add(estado);
            }

            conexion.Close();

            return lstEstado;
        }
    }
}
