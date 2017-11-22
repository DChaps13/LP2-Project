/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.ClienteNaturalDA;
import Modelo.*;
/**
 *
 * @author Emanuel
 */
import java.util.ArrayList;
public class ClienteNaturalBL {
    
    public ClienteNaturalDA accesoDatos;
    
    public ClienteNaturalBL(){
        accesoDatos = new ClienteNaturalDA();
    }
    
    public boolean eliminarClienteNatural(int id){
        return accesoDatos.eliminarClienteNatural(id);
    }
    
    public boolean actualizarClienteNatural(ClienteNatural x){
        return accesoDatos.actualizarClienteNatural(x);
    }
    
    public ArrayList<ClienteNatural> devolverClientesNaturales(int id, String nombre, String apellido, String DNI, String telefono, String correo){
        return accesoDatos.devolverClientesNaturales(id, nombre, apellido, DNI, telefono, correo);
    }
    
}
