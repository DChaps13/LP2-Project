
package Modelo;

public class RolUsuario {

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }
    private int id;
    private String descriptor;
    private int privilegio;

    public RolUsuario(){}
    
    public RolUsuario(String descriptor, int privilegio){
        this.descriptor = descriptor;
        this.privilegio = privilegio;
    }
    
    public String getDescriptor() {
        return descriptor;
    }

    public void setDescriptor(String descriptor) {
        this.descriptor = descriptor;
    }

    public int getPrivilegio() {
        return privilegio;
    }

    public void setPrivilegio(int privilegio) {
        this.privilegio = privilegio;
    }
    
    
}
