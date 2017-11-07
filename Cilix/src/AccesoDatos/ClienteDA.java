
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
}
