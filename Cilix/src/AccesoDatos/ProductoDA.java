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
                p.setCategoria(rs.getString("Categoria"));
                lista.add(p);
            }
            return lista;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
