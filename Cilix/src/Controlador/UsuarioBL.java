
package Controlador;

import AccesoDatos.UsuarioDA;
import Modelo.RolUsuario;
import Modelo.Usuario;
import java.sql.ResultSet;
import java.util.ArrayList;

public class UsuarioBL {
    UsuarioDA accesoDatosUsuario;
    
    public UsuarioBL(){
        accesoDatosUsuario = new UsuarioDA();
    }
    
    public ArrayList<Usuario> devolverUsuarios(){
        return accesoDatosUsuario.devolverUsuarios();
    }
    
    public ArrayList<RolUsuario> listarRoles(){
        return accesoDatosUsuario.listarRoles();
    }

    public ArrayList<Usuario> devolverUsuarios(String s1, String s2) {
        return accesoDatosUsuario.devolverUsuarios(s1,s2);
    }
   
}
