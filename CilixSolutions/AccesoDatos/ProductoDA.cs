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
    public class ProductoDA
    {
        public ProductoDA()
        {

        }

        public bool registrarProducto(Producto p)
        {
            ConexionBD cadConexion = new ConexionBD();
            string query = "INSERT INTO dbo.Usuario(Id,Nombre,Cantidad,Precio,Estado,Categoria,fechaUltModif,fechaLanzamiento,stock_minimo,Id_Proveedor) VALUES('" + p.Id + "','" + p.Nombre + "','" + 0 + " ' , ' " + 0 + "','" + p.Estado + "','" + p.Categoria + "'," + p.Fecha_Ult_modificacion.ToString() + "," + p.Fecha_Lanzamiento.ToString() + " ','" + 0 + " ','" + p.Proveedor.Id_contacto + ")";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;

            conexion.Open();
            sentencia.ExecuteNonQuery();

            conexion.Close();
            return true;
        }

        public BindingList<Producto> devolverLista()
        {
            BindingList<Producto> productos = new BindingList<Producto>();

            ConexionBD cadConexion = new ConexionBD();
            string query = "SELECT p.*, cj.RazonSocial as 'razon',cj.Telefono as 'tlf', cj.Correo as 'correo', cj.RUC as 'ruc' " +
                "FROM dbo.Usuario p " +
                "INNER JOIN dbo.ClienteJuridico cj ON p.Id = cj.Id";
            SqlConnection conexion = new SqlConnection(cadConexion.CadenaConexion);
            SqlCommand sentencia = conexion.CreateCommand();
            sentencia.CommandText = query;


            conexion.Open();
            SqlDataReader reader = sentencia.ExecuteReader();


            while (reader.Read())
            {
                CategoriaProd cat = new CategoriaProd(reader["Categoria"].ToString());
                PersonaJuridica pj = new PersonaJuridica(
                    reader["razon"].ToString(),
                    reader["ruc"].ToString(),
                    reader["tlf"].ToString(),
                    reader["Correo"].ToString());
                Producto p = new Producto(
                    reader["Id"].ToString(), 
                    reader["Nombre"].ToString(), 
                    Int32.Parse(reader["Cantidad"].ToString()), 
                    Double.Parse(reader["Precio"].ToString()), 
                    reader["Estado"].ToString(), 
                    cat, 
                    DateTime.Parse(reader["fechaUltModif"].ToString()), 
                    DateTime.Parse(reader["fechaLanzamiento"].ToString()), 
                    Int32.Parse(reader["stock_minimo"].ToString()), 
                    pj);
                productos.Add(p);
            }

            conexion.Close();
            return productos;
        }
    }
}
