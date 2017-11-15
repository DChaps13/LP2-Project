/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Cliente;
import Modelo.ClienteNatural;
import Modelo.Empresa;
import Modelo.Producto;
import Modelo.Transaccion;
import Modelo.Usuario;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

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
            ps.setString(7, t.getUsuario().getId());    
            ps.execute();
            /* ACTUALIZAR LA TABLA PRODUCTO */
            /*
            String actualizar = "{call dbo.actualizarCantidadProducto(?,?)}";
            ps = conn.prepareStatement(actualizar);
            ps.setInt(1,t.getIdProducto());
            ps.setInt(2,t.getCantidad());
            ps.execute();*/
            return true;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return false;
    }
    
    public ArrayList<Transaccion> devolverTransacciones( ArrayList<Cliente> clientes, ArrayList<Producto> productos, ArrayList<Usuario> usuarios ){
        ArrayList<Transaccion> lista = new ArrayList<Transaccion>();
        try{    
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            
            // formar query
            String query = "SELECT * FROM Transacción ";
            String extra = "";
            
            if(clientes.size() > 0){
                extra = extra + " ( ";
                for(int i = 0; i < clientes.size(); ++i){
                    if(i > 0) extra = extra + " OR ";
                    extra = extra + " Id_Usuario =  " + "'" + clientes.get(i).getId() + "' ";
                }
                extra = extra + " ) ";
            }
            
            if(productos.size() > 0){
                if(!extra.equals("")) extra = extra + " AND ";
                extra = extra + " ( ";
                for(int i = 0; i < productos.size(); ++i){
                    if(i > 0) extra = extra + " OR ";
                    extra = extra + " Id_Producto = " + "'" + productos.get(i).getId() + "' ";
                }
                extra = extra + " ) ";
            }
            
            if(usuarios.size() > 0){
                if(!extra.equals("")) extra = extra + " AND ";
                extra = extra + " ( ";
                for(int i = 0; i < usuarios.size(); ++i){
                    if(i > 0) extra = extra + " OR ";
                    extra = extra + " Id_Usuario = " + "'" + usuarios.get(i).getId() + "' ";
                }
                extra = extra + " ) ";
            }

            ResultSet rs = sentencia.executeQuery(query);
            while(rs.next()){
                Transaccion t = new Transaccion();
                /* SOLO FALTA EXTRAER DATOS DE TRANSACCION */
                lista.add(t);
            }
            conn.close();
        }catch (Exception e){
            // do something appropriate with the exception, *at least*:
            System.out.println(e.getMessage());
        }
        
        return null; 
    }
}
