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
    public class PerJuridicaDA
    {
        public PerJuridicaDA()
        {

        }


        public bool registrarPJ(PersonaJuridica c)
        {
            return true;
        }

        public BindingList<PersonaJuridica> devolverLista()
        {
            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT * FROM dbo.ClienteJuridico";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();

            BindingList<PersonaJuridica> lista = new BindingList<PersonaJuridica>();
            while (reader.Read())
            {
                PersonaJuridica prov = new PersonaJuridica(reader["RazonSocial"].ToString(), reader["RUC"].ToString(), reader["Telefono"].ToString(), reader["Correo"].ToString());
                lista.Add(prov);
            }

            conexion.Close();

            return lista;
        }

        public BindingList<PersonaJuridica> devolverProveedores()
        {
            ConexionBD cadConexion = new ConexionBD();

            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.listarProveedores";

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();

            BindingList<PersonaJuridica> lista = new BindingList<PersonaJuridica>();
            while (reader.Read())
            {
                PersonaJuridica prov = new PersonaJuridica(reader["RazonSocial"].ToString(), reader["RUC"].ToString(), reader["Telefono"].ToString(), reader["Correo"].ToString());
                lista.Add(prov);
            }

            conexion.Close();

            return lista;
        }

    }
}
