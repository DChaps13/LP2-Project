/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Producto;
import Modelo.Usuario;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author Emanuel
 */
public class ProductoDA {
    
    public ProductoDA(){}
    
    public ArrayList<Producto> devolverProductos(){
        try {
            //registrar el Driver
            ArrayList<Producto> lista = new ArrayList<Producto>();
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("Select * FROM Producto;");
            while(rs.next()){
                Producto p = new Producto();
                p.setId(rs.getInt("Id"));
                p.setNombre(rs.getString("Nombre"));
                p.setCantidad(rs.getInt("Cantidad"));
                p.setPrecio(rs.getFloat("Precio"));
                p.setEstado(rs.getString("Estado"));
//                p.setCategoria(rs.getString("Categoria"));
                lista.add(p);
            }
            return lista;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
    public ArrayList<Producto> devolverProductos(String id, String nombre){
        
        try {
            //registrar el Driver
            ArrayList<Producto> lista = new ArrayList<Producto>();
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            String s = "{call dbo.buscarProductoConParam(?,?)}";
            PreparedStatement ps = conn.prepareStatement(s);         
            int idAux=0;
            if(id.equals("")) 
                idAux=-1;
            else 
                idAux= Integer.parseInt(id);
                    
            ps.setInt(1,idAux );
            ps.setString(2, nombre);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Producto p = new Producto();
                p.setId(rs.getInt("Id"));
                p.setNombre(rs.getString("Nombre"));
                p.setCantidad(rs.getInt("Cantidad"));
                p.setPrecio(rs.getFloat("Precio"));
                p.setEstado(rs.getString("Estado"));
//                p.setCategoria(rs.getString("Categoria"));
                lista.add(p);
            }
            return lista;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
    public Producto getProductobyId(int idProd){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            ResultSet rsId;
            Producto p = new Producto();
            String query = "SELECT * FROM dbo.Producto WHERE Id = ";
            query += Integer.toString(idProd);
            rsId=sentencia.executeQuery(query);
            rsId.next();
            p.setId(rsId.getInt("Id"));
            p.setNombre(rsId.getString("Nombre"));
            p.setCantidad(rsId.getInt("Cantidad"));
            p.setPrecio(rsId.getFloat("Precio"));
            p.setEstado(rsId.getString("Estado"));
            p.setFechaLanzamiento(rsId.getDate("fechaLanzamiento"));
            p.setFechaUltMod(rsId.getDate("fechaUltModif"));
            p.setStockMinimo(rsId.getInt("stock_minimo"));
            p.setIdProveedor(rsId.getInt("Id_Proveedor"));
//                p.setCategoria("");
            
            return p;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
