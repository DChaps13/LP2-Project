/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.ClienteNatural;
import Modelo.Empresa;
import Modelo.Transaccion;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

/**
 *
 * @author Emanuel
 */
public class TransaccionDA {
    
    public TransaccionDA(){}
    
    public int getID(){
        try {
            //registrar el Driver
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("SELECT Id FROM Transacción  WHERE Id=( " + 
                    "    SELECT max(Id) FROM Transacción  )");
            if(!rs.next()) return 1;
            return rs.getInt("Id") + 1;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return -1;
    }
    
    public boolean registrarVenta(Transaccion t){
        
        try {
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            String insertar = "{call dbo.insertarTransaccionVenta(?,?,?,?,?,?,?)}";
            PreparedStatement ps = conn.prepareStatement(insertar);
            ps.setInt(1,getID());
            ps.setInt(2,t.getCantidad());
            ps.setString(3, t.getDescripcion());
            ps.setString(4, t.getDestino());
            ps.setInt(5, t.getIdContacto());
            ps.setInt(6, t.getIdProducto());
            ps.setString(7, "" + t.getIdUsuario());
            ps.execute();
            /* ACTUALIZAR LA TABLA PRODUCTO */
            String actualizar = "{call dbo.actualizarCantidadProducto(?,?)}";
            ps = conn.prepareStatement(actualizar);
            ps.setInt(1,t.getIdProducto());
            ps.setInt(2,t.getCantidad());
            ps.execute();
            return true;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return false;
    }
    
}
