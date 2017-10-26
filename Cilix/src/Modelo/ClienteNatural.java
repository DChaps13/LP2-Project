/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

public class ClienteNatural extends Cliente{
    private String dni;
    private String nombres;
    
    public ClienteNatural(){}
    
    public ClienteNatural(String direccion, String telefono, String email, String dni, String nombres){
        super(direccion,telefono,email);
        this.dni = dni;
        this.nombres = nombres;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }
    
    
}
