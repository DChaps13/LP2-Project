
package AccesoDatos;

import Modelo.Cliente;
import java.sql.Connection;
import java.sql.DriverManager;
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
            
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
}
