
package Controlador;

import AccesoDatos.UsuarioDA;
import java.sql.ResultSet;
import java.util.ArrayList;

public class UsuarioBL {
    UsuarioDA accesoDatosUsuario;
    
    public UsuarioBL(){
        accesoDatosUsuario = new UsuarioDA();
    }
    
    public ResultSet devolverUsuarios(){
        return accesoDatosUsuario.devolverUsuarios();
    }
   
}
