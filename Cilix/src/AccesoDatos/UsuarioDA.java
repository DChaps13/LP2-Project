
package AccesoDatos;

import Modelo.Usuario;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class UsuarioDA {
    
    public UsuarioDA(){}
    
    public ArrayList<Usuario> devolverUsuarios(){
        try {
            //registrar el Driver
            ArrayList<Usuario> lista = new ArrayList<Usuario>();
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("Select * FROM Usuario;");
            while(rs.next()){
                String id = rs.getString("Id");
                String pass = rs.getString("Contraseña");
                Date fechaCreacion = rs.getDate("fechaCreacion");
                Date fechaMod = rs.getDate("fechaModificacion");
                Usuario u = new Usuario();
                u.setId(id);
                u.setPassword(pass);
                u.setFechaCreacion(fechaCreacion);
                u.setFechaModificacion(fechaMod);
                lista.add(u);
            }
            return lista;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
