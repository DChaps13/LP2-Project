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
            ConexionBD cadConexion = new ConexionBD();
            string query = "INSERT INTO dbo.Usuario(Id,Contraseña,fechaCreacion,fechaModificacion,Id_Rol,Id_Estado) VALUES('" + u.Id + "','" + u.Contraseña + "','" + u.FechaCreacion.ToString() + "','" + u.FechaModificacion.ToString() + "'," + u.Rol.Id + "," + u.Estado.Id + ")";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            sentencia.ExecuteNonQuery();

            conexion.Close();

            return true;
        }

        public BindingList<Usuario> devolverLista()
        {
            BindingList<Usuario> lstUsuarios = new BindingList<Usuario>();

            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT u.*, r.Nombre as 'Nombre_Rol', r.Privilegio, e.Nombre as 'Nombre_Estado' FROM dbo.Usuario u INNER JOIN dbo.Rol r ON u.Id_Rol = r.Id INNER JOIN dbo.Estado e ON u.Id_Estado = e.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;


            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();


            while (reader.Read())
            {
                RolUsuario rol = new RolUsuario(Int32.Parse(reader["Id_Rol"].ToString()), reader["Nombre_Rol"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                Estado estado = new Estado(Int32.Parse(reader["Id_Estado"].ToString()), reader["Nombre_Estado"].ToString());
                Usuario us = new Usuario(reader["Id"].ToString(), reader["Contraseña"].ToString(), DateTime.Parse(reader["fechaCreacion"].ToString()), DateTime.Parse(reader["fechaModificacion"].ToString()), estado, rol);
                lstUsuarios.Add(us);
            }

            conexion.Close();
            
            return lstUsuarios;
        }
    }
}
