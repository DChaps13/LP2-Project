using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

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

        public BindingList<PersonaJuridica> buscarProveedor(string rSocial,string ruc)
        {
            BindingList<PersonaJuridica> proveedores = new BindingList<PersonaJuridica>();
            ConexionBD cadConexion = new ConexionBD();
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            //sentencia.CommandText = "dbo.buscarProveedor"; CREAR PROCEDURE ALMACENADO ANTES DE CORRERLO
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.Add("@_rSocial", SqlDbType.VarChar).Value = rSocial;
            sentencia.Parameters.Add("@_ruc", SqlDbType.VarChar).Value = ruc;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();
            while (reader.Read())
            {
                PersonaJuridica proveedor = new PersonaJuridica(reader["RazonSocial"].ToString(), reader["RUC"].ToString(), reader["Telefono"].ToString(), reader["Correo"].ToString());
                proveedores.Add(proveedor);
            }

            conexion.Close();

            return proveedores;
        }
    }
}
