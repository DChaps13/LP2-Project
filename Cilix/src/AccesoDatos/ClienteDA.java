
package AccesoDatos;

import Modelo.Cliente;
import Modelo.ClienteNatural;
import Modelo.Empresa;
import Modelo.Usuario;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class ClienteDA {
    public ClienteDA(){}
    
    public int getID(){
        try {
            //registrar el Driver
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("SELECT Id FROM ClienteJuridico  WHERE Id=( " + 
                    "    SELECT max(Id) FROM ClienteJuridico  )");
            rs.next();
            return rs.getInt("Id") + 1;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return -1;
    }
    
    public boolean agregarCliente(Cliente c){
        try {
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            System.out.println("HOLI");
            //int ID = getID();
            //if(ID == -1) return false;
            if(c instanceof ClienteNatural){
                System.out.println("HOLI");
                String insertar = "{call dbo.insertarClienteNatural(?,?,?,?,?)}";
                PreparedStatement ps = conn.prepareStatement(insertar);
                //CallableStatement ps = conn.prepareCall(insertar);
                //ps.setInt(1,ID);
                
                ps.setString(1, ((ClienteNatural) c).getNombre());
                ps.setString(2, ((ClienteNatural) c).getApellido());
                ps.setString(3, ((ClienteNatural) c).getDni());
                ps.setString(4, c.getTelefono());
                ps.setString(5, c.getEmail());
                ps.execute();
            }else if(c instanceof Empresa){
                String insertar = "{call dbo.insertarEmpresa(?,?,?,?,?)}";
                PreparedStatement ps = conn.prepareStatement(insertar);
              //  ps.setInt(1, ID);
                
                ps.setString(1, ((Empresa) c).getRazonSocial());
                ps.setString(2, c.getTelefono());
                ps.setString(3, c.getEmail());
                ps.setString(4, ((Empresa) c).getRuc());
                ps.setString(5, ((Empresa) c).getTipo());
                ps.execute();
            }
            conn.close();
            return true;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return false;
    }
    
    public ArrayList<Cliente> devolverClientes(String id,String nombres, String apellidos, String dni, String telefono, String email, String razon, String ruc){
        ArrayList<Cliente> lista = new ArrayList<Cliente>();
        try{    
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            
            
            String buscarCNatural = "{call dbo.buscarClienteNatural(?,?,?,?,?,?)}";
            PreparedStatement ps = conn.prepareStatement(buscarCNatural);
            if (id.equals("")) id="-1";
            ps.setInt(1, Integer.parseInt(id));
            ps.setString(2, nombres);
            ps.setString(3, apellidos);
            ps.setString(4, dni);
            ps.setString(5, telefono);
            ps.setString(6, email);
            
            ResultSet rs = ps.executeQuery();

            while (rs.next()){
                ClienteNatural cl = new ClienteNatural();
                
                cl.setId(rs.getInt("Id"));
                cl.setNombre(rs.getString("Nombre"));
                cl.setApellido(rs.getString("Apellido"));
                cl.setDni(rs.getString("DNI"));
                cl.setTelefono(rs.getString("Telefono"));
                cl.setEmail(rs.getString("Correo"));
                lista.add(cl);
            }
            
            String buscarEmpresa = "{call dbo.buscarEmpresa(?,?,?,?,?,?)}";
            PreparedStatement ps2 = conn.prepareStatement(buscarEmpresa);
            
            
            ps2.setInt(1, Integer.parseInt(id));
            ps2.setString(2, razon);
            ps2.setString(3, ruc);
            ps2.setString(4, telefono);
            ps2.setString(5, email);
            ps2.setString(6,"Cliente");
            
            ResultSet rs2 = ps2.executeQuery();
            
            while (rs2.next()){
                Empresa e = new Empresa();
                
                e.setId(rs2.getInt("Id"));
                e.setRazonSocial(rs2.getString("RazonSocial"));
                e.setRuc(rs2.getString("RUC"));
                e.setTelefono(rs2.getString("Telefono"));
                e.setEmail(rs2.getString("Correo"));
                e.setTipo(rs2.getString("Tipo"));
                lista.add(e);
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
