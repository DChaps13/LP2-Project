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
    public class ProductoDA
    {
        public ProductoDA()
        {

        }

        public bool registrarProducto(String nombreProveeedor, Producto p)
        {
            ConexionBD cadConexion = new ConexionBD();
            //string query = "INSERT INTO dbo.Usuario(Id,Nombre,Cantidad,Precio,Estado,Categoria,fechaUltModif,fechaLanzamiento,stock_minimo,Id_Proveedor) VALUES('" + p.Id + "','" + p.Nombre + "','" + 0 + " ' , ' " + 0 + "','" + p.Estado + "','" + p.Categoria + "'," + p.Fecha_Ult_modificacion.ToString() + "," + p.Fecha_Lanzamiento.ToString() + " ','" + 0 + " ','" + p.Proveedor.Id_contacto + ")";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();

            sentencia.CommandText = "dbo.insertarProducto";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.Add("@_nombre", SqlDbType.VarChar).Value = p.Nombre;
            sentencia.Parameters.Add("@_proveedor", SqlDbType.VarChar).Value = nombreProveeedor;
            sentencia.Parameters.Add("@_categoria", SqlDbType.VarChar).Value = p.Categoria.Nombre;
            sentencia.Parameters.Add("@_stockInicial", SqlDbType.Int).Value = p.Cantidad;
            sentencia.Parameters.Add("@_precio", SqlDbType.Float).Value = p.Precio;

            conexion.Open();
            sentencia.ExecuteNonQuery();

            conexion.Close();
            return true;
        }

        public BindingList<Producto> devolverLista(string nombre, string categoria, string proveedor)
        {
            BindingList<Producto> productos = new BindingList<Producto>();

            ConexionBD cadConexion = new ConexionBD();
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = "dbo.buscarProducto";
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            sentencia.Parameters.Add("@_nombre", SqlDbType.VarChar).Value = nombre;
            sentencia.Parameters.Add("@_categoria", SqlDbType.VarChar).Value = categoria;
            sentencia.Parameters.Add("@_proveedor", SqlDbType.VarChar).Value = proveedor;

            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();


            while (reader.Read())
            {
                CategoriaProd cat = new CategoriaProd(Int32.Parse(reader["Id_Categoria"].ToString()), reader["Nombre_Categoria"].ToString());
                PersonaJuridica prov = new PersonaJuridica(Int32.Parse(reader["Id_Proveedor"].ToString()), reader["RazonSocial"].ToString());
                Producto prod = new Producto(Int32.Parse(reader["Id"].ToString()), reader["Nombre"].ToString(), Int32.Parse(reader["Cantidad"].ToString()), Double.Parse(reader["Precio"].ToString()), reader["Estado"].ToString(),cat,prov);
                productos.Add(prod);
            }

            conexion.Close();
            return productos;
        }
    }
}
