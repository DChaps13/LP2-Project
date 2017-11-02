using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class UsuarioDA
    {
        public UsuarioDA()
        {

        }

        public bool registrarUsuario(Usuario u)
        {
            return true;
        }

        public BindingList<Usuario> devolverLista()
        {
            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT u.*, r.Nombre as 'Nombre_Rol', r.Privilegio, e.Nombre as 'Nombre_Estado' FROM dbo.Usuario u INNER JOIN dbo.Rol r ON u.Id_Rol = r.Id INNER JOIN dbo.Estado e ON u.Id_Estado = e.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();

            BindingList<Usuario> lstUsuarios = new BindingList<Usuario>();
            while (reader.Read())
            {
                RolUsuario rol = new RolUsuario(Int32.Parse(reader["Id_Rol"].ToString()), reader["Nombre_Rol"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                Estado est = new Estado(Int32.Parse(reader["Id_Estado"].ToString()), reader["Nombre_Estado"].ToString());
                //Usuario us = new Usuario(reader["Id"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                //lstUsuarios.Add(us);
            }

            conexion.Close();

            
            return lstUsuarios;
        }
    }
}
