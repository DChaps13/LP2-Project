/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;
import Modelo.*;
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
public class ClienteNaturalDA {
    
    public ClienteNaturalDA(){
        
    }
    
    public boolean eliminarClienteNatural(int id){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            String sentence = "{call dbo.eliminarClienteNatural(?)}";
            PreparedStatement ps = conn.prepareStatement(sentence);
            ps.setInt(1,id);
            ps.execute();
            conn.close();
            return true;
        }catch(Exception ex){
            System.out.println("Hubieron problemas con la base de datos");
        }
        return false;
    }
    
    public boolean actualizarClienteNatural(ClienteNatural x){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            String sentence = "{call dbo.actualizarClienteNatural(?,?,?,?,?,?)}";
            PreparedStatement ps = conn.prepareStatement(sentence);
            ps.setInt(1,x.getId());
            ps.setString(2,x.getNombre());
            ps.setString(3,x.getApellido());
            ps.setString(4,x.getDni());
            ps.setString(5,x.getTelefono());
            ps.setString(6,x.getEmail());
            ps.execute();
            conn.close();
            return true;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return false;
    }
    
    public ArrayList<ClienteNatural> devolverClientesNaturales(int id, String nombre, String apellido, String dni, String telefono, String correo){
        ArrayList<ClienteNatural> lista = new ArrayList<ClienteNatural>();
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            String buscarCNatural = "{call dbo.buscarClienteNatural(?,?,?,?,?,?)}";
            PreparedStatement ps = conn.prepareStatement(buscarCNatural);     
            ps.setInt(1,id);
            ps.setString(2, nombre);
            ps.setString(3, apellido);
            ps.setString(4, dni);
            ps.setString(5, telefono);
            ps.setString(6, correo);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                ClienteNatural x = new ClienteNatural();
                x.setId(rs.getInt("Id"));
                x.setNombre(rs.getString("Nombre"));
                x.setApellido(rs.getString("Apellido"));
                x.setDni(rs.getString("DNI"));
                x.setTelefono(rs.getString("Telefono"));
                x.setEmail(rs.getString("Correo"));
                lista.add(x);
            }
            conn.close();
            return lista;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
