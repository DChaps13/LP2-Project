
package Controlador;

import AccesoDatos.UsuarioDA;
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
   
}
