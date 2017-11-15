
package Modelo;

import java.util.Date;

public class Usuario {
    private String id;
    private String password;
    private Date fechaCreacion;
    private Date fechaModificacion;
    private String estado;
    private RolUsuario rol;

    public Usuario(){
        RolUsuario x = new RolUsuario();
        x.setDescriptor("Estándar");
        x.setPrivilegio(1);
        this.setRol(x);
    }
    
    public Usuario(String id, String password, Date fechaCreacion, Date fechaModificacion, String estado, RolUsuario rol){
        this.id = id;
        this.password = password;
        this.fechaCreacion = fechaCreacion;
        this.fechaModificacion = fechaModificacion;
        this.estado = estado;
        this.rol = rol;
    }
    
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Date getFechaModificacion() {
        return fechaModificacion;
    }

    public void setFechaModificacion(Date fechaModificacion) {
        this.fechaModificacion = fechaModificacion;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public RolUsuario getRol() {
        return rol;
    }

    public void setRol(RolUsuario rol) {
        this.rol = rol;
    }
    
    
    
}
