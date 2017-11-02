
package AccesoDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class UsuarioDA {
    
    public UsuarioDA(){}
    
    public ResultSet devolverUsuarios(){
        try {
            //registrar el Driver Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("Select ...");
            return rs;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
