using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

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
            string query = "INSERT INTO dbo.Usuario(Id,Contraseña,fechaCreacion,Id_Rol,Id_Estado) VALUES('" + u.Id + "','" + u.Contraseña + "'," + "GETDATE ( )" + "," + u.Rol.Id + "," + u.Estado.Id + ")";

            
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

           
            try
            {
                conexion.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje de error");

            }
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

            try
            {


                conexion.Open();
                SqlDataReader reader = sentencia.ExecuteReader();


                while (reader.Read())
                {
                    RolUsuario rol = new RolUsuario(Int32.Parse(reader["Id_Rol"].ToString()), reader["Nombre_Rol"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                    Estado estado = new Estado(Int32.Parse(reader["Id_Estado"].ToString()), reader["Nombre_Estado"].ToString());
                    Usuario us = new Usuario(reader["Id"].ToString(), reader["Contraseña"].ToString(), DateTime.Parse(reader["fechaCreacion"].ToString()), estado, rol);
                    lstUsuarios.Add(us);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje de error");
                return lstUsuarios;
            }

            conexion.Close();
            
            return lstUsuarios;
        }

        public BindingList<Usuario> buscarUsuario(string _id, string _rol, string _estado)
        {
            BindingList<Usuario> lstUsuarios = new BindingList<Usuario>();

            ConexionBD cadConexion = new ConexionBD();
            //string query = "SELECT u.*, r.Nombre as 'Nombre_Rol', r.Privilegio, e.Nombre as 'Nombre_Estado' FROM dbo.Usuario u INNER JOIN dbo.Rol r ON u.Id_Rol = r.Id INNER JOIN dbo.Estado e ON u.Id_Estado = e.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.buscarUsuario";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.Add("@_id", SqlDbType.VarChar).Value = _id;
            sentencia.Parameters.Add("@_rol", SqlDbType.VarChar).Value = _rol;
            sentencia.Parameters.Add("@_estado", SqlDbType.VarChar).Value = _estado;

            try
            {
                conexion.Open();
                SqlDataReader reader = sentencia.ExecuteReader();


                while (reader.Read())
                {
                    RolUsuario rol = new RolUsuario(Int32.Parse(reader["Id_Rol"].ToString()), reader["Nombre_Rol"].ToString(), Int32.Parse(reader["Privilegio"].ToString()));
                    Estado estado = new Estado(Int32.Parse(reader["Id_Estado"].ToString()), reader["Nombre_Estado"].ToString());
                    Usuario us = new Usuario(reader["Id"].ToString(), reader["Contraseña"].ToString(), DateTime.Parse(reader["fechaCreacion"].ToString()), estado, rol);
                    lstUsuarios.Add(us);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje de error");
                return lstUsuarios;
            }


            conexion.Close();
            
            return lstUsuarios;
        }

        public bool modificarUsuario(string contrNuevo, string rolNuevo, string idAntiguo)
        {
            ConexionBD cadConexion = new ConexionBD();
            //string query = "SELECT u.*, r.Nombre as 'Nombre_Rol', r.Privilegio, e.Nombre as 'Nombre_Estado' FROM dbo.Usuario u INNER JOIN dbo.Rol r ON u.Id_Rol = r.Id INNER JOIN dbo.Estado e ON u.Id_Estado = e.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.ModificarUsuario";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            
            sentencia.Parameters.Add("@_contrasenaNuevo", SqlDbType.VarChar).Value = contrNuevo;
            sentencia.Parameters.Add("@_rol", SqlDbType.VarChar).Value = rolNuevo;
            sentencia.Parameters.Add("@_idLlave", SqlDbType.VarChar).Value = idAntiguo;

            try
            {
                conexion.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje de error");

            }
            conexion.Close();

            return true;
        }

        public bool eliminarUsuario(string id)
        {

            ConexionBD cadConexion = new ConexionBD();
            //string query = "SELECT u.*, r.Nombre as 'Nombre_Rol', r.Privilegio, e.Nombre as 'Nombre_Estado' FROM dbo.Usuario u INNER JOIN dbo.Rol r ON u.Id_Rol = r.Id INNER JOIN dbo.Estado e ON u.Id_Estado = e.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.EliminarUsuario";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;

            sentencia.Parameters.Add("@_id", SqlDbType.VarChar).Value = id;
            

            try
            {
                conexion.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje de error");

            }
            conexion.Close();

            return true;

        }

    }
}
