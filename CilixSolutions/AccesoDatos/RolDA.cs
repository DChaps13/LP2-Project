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
    public class RolDA
    {
        public RolDA()
        {

        }

        public bool registrarRol(RolUsuario r)
        {
            return true;
        }

        public BindingList<RolUsuario> devolverLista()
        {
            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT * FROM dbo.Rol";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();

            BindingList<RolUsuario> lstRoles = new BindingList<RolUsuario>();
            while (reader.Read())
            {
                RolUsuario rol = new RolUsuario(Int32.Parse(reader["Id"].ToString()),reader["Nombre"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                lstRoles.Add(rol);
            }

            conexion.Close();

            return lstRoles;
        }
    }
}
