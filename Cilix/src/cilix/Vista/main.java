
package cilix.Vista;

import Controlador.UsuarioBL;
import Modelo.Usuario;

public class main {
    
    private Usuario user;
    
    public static void main(String[] args){
        frmLogueo logueo = new frmLogueo(null,true);
        logueo.setVisible(true);
    }

    public Usuario getUser() {
        return user;
    }

    public void setUser(Usuario user) {
        this.user = user;
    }
    
}
