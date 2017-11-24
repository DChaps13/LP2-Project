
package AccesoDatos;

import Modelo.*;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class UsuarioDA {
    
    public UsuarioDA(){}
    
    
    public ArrayList<RolUsuario> listarRoles(){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            String buscarCNatural = "{call dbo.listarRoles()}";
            PreparedStatement ps = conn.prepareStatement(buscarCNatural);     
            
            ResultSet rs = ps.executeQuery();
            ArrayList<RolUsuario> lista  = new ArrayList<RolUsuario>();
            
            while(rs.next()){
                RolUsuario r = new RolUsuario();
                r.setId(rs.getInt("Id"));
                r.setDescriptor(rs.getString("Descriptor"));
                r.setPrivilegio(rs.getInt("Privilegio"));
                lista.add(r);
            }
            conn.close();
            return lista;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
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
                RolUsuario r = new RolUsuario();
                r.setPrivilegio(rs.getInt("Id_Rol"));
                Usuario u = new Usuario();
                u.setRol(r);
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
    
    public Usuario getUsuariobyId(String idUsu){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            ResultSet rsId;
            
            Usuario u = new Usuario();
            String query = "SELECT * FROM dbo.Usuario WHERE Id = '";
            query += idUsu + "'";
            rsId=sentencia.executeQuery(query);
            rsId.next();
            u.setId(rsId.getString("Id"));
            u.setPassword(rsId.getString("Contraseña"));
            u.setFechaCreacion(rsId.getDate("fechaCreacion"));
            u.setFechaModificacion(rsId.getDate("fechaModificacion"));
//            u.setRol();
//            u.setEstado();
            
            return u;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    }

    public ArrayList<Usuario> devolverUsuarios(String id, String rol) {
         try {
            //registrar el Driver
            ArrayList<Usuario> lista = new ArrayList<Usuario>();
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140;databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            Statement st = conn.createStatement();
            String s = "{call dbo.buscarUsuarioConParam(?,?)}";
            PreparedStatement ps = conn.prepareStatement(s);       
            
            ps.setString(1,id );
            ps.setString(2, rol);
            ResultSet rs = ps.executeQuery();
            
            ArrayList<RolUsuario> listaRoles = new ArrayList<RolUsuario>();
            listaRoles = listarRoles();
            while(rs.next()){
                String idUsr = rs.getString("Id");
                String pass = rs.getString("Contraseña");
                Date fechaCreacion = rs.getDate("fechaCreacion");
                Date fechaMod = rs.getDate("fechaModificacion");
                RolUsuario r = new RolUsuario();
                
                for(int j=0;j<listaRoles.size();j++){
                    if(listaRoles.get(j).getId() == rs.getInt("Id_Rol")){
                        r = listaRoles.get(j);
                        break;
                    };
                }
                    
                Usuario u = new Usuario();
                u.setRol(r);
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
