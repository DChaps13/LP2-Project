
package AccesoDatos;

import Modelo.Cliente;
import Modelo.ClienteNatural;
import Modelo.Empresa;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class ClienteDA {
    public ClienteDA(){}
    
    public void agregarCliente(Cliente c){
        try {
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            System.out.println("HOLI");
            if(c instanceof ClienteNatural){
                System.out.println("HOLI");
                String insertar = "{call dbo.insertarClienteNatural(?,?,?,?,?,?,?)}";
                PreparedStatement ps = conn.prepareStatement(insertar);
                //CallableStatement ps = conn.prepareCall(insertar);
                ps.setInt(1,10);
                ps.setInt(2,1);
                ps.setString(3, ((ClienteNatural) c).getNombre());
                ps.setString(4, ((ClienteNatural) c).getApellido());
                ps.setString(5, ((ClienteNatural) c).getDni());
                ps.setString(6, c.getTelefono());
                ps.setString(7, c.getEmail());
                ps.execute();
            }else if(c instanceof Empresa){
                String insertar = "{call dbo.insertarClienteJuridico(?,?,?,?,?,?)}";
                PreparedStatement ps = conn.prepareStatement(insertar);
                ps.setInt(1, 7);
                ps.setInt(2, 2);
                ps.setString(3, ((Empresa) c).getRazonSocial());
                ps.setString(4, c.getTelefono());
                ps.setString(5,c.getEmail());
                ps.setString(6, ((Empresa) c).getRuc());
                ps.execute();
            }
            conn.close();
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
    
    public ArrayList<Cliente> devolverClientes(String id, String telefono, String email){
        ArrayList<Cliente> lista = new ArrayList<Cliente>();
        try{    
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            
            // formar query
            String query = "SELECT * FROM ClienteNatural ";
            String extra = "";
            if(!id.equals("")) extra = extra + "Id = " + id;
            if(!telefono.equals("")){
                if(!extra.equals("")) extra = extra + " AND "; 
                extra = extra + " Telefono = " + telefono;
            }
            if(!email.equals("")){
                if(!extra.equals("")) extra = extra + " AND ";
                extra = extra + " Correo = " + email;
            }
            if(!extra.equals("")) query = query + " WHERE " + extra;
            
            ResultSet rs = sentencia.executeQuery(query);
            while(rs.next()){
                int _id = rs.getInt("Id");
                String _telefono = rs.getString("Telefono");
                String _email = rs.getString("Email");
                ClienteNatural c = new ClienteNatural();
                c.setId(_id);
                c.setTelefono(_telefono);
                c.setEmail(_email);
                lista.add(c);
            }
                
            query = "SELECT * FROM ClienteJuridico ";
            extra = "";
            if(!id.equals("")) extra = extra + "Id = " + id;
            if(!telefono.equals("")){
                if(!extra.equals("")) extra = extra + " AND "; 
                extra = extra + " Telefono = " + telefono;
            }
            if(!email.equals("")){
                if(!extra.equals("")) extra = extra + " AND ";
                extra = extra + " Correo = " + email;
            }
            if(!extra.equals("")) query = query + " WHERE " + extra;
            
            rs = sentencia.executeQuery(query);
            while(rs.next()){
                int _id = rs.getInt("Id");
                String _telefono = rs.getString("Telefono");
                String _email = rs.getString("Email");
                Empresa c = new Empresa();
                c.setId(_id);
                c.setTelefono(_telefono);
                c.setEmail(_email);
                lista.add(c);
            }
            
            conn.close();
        }
        catch (Exception e){
            // do something appropriate with the exception, *at least*:
            System.out.println(e.getMessage());
        }
        
        return lista;
    }
    
}
