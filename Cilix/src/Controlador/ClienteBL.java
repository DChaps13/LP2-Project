/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.ClienteDA;
import Modelo.Cliente;
import java.util.ArrayList;

public class ClienteBL {
    
    ClienteDA accesoDatos;
    
    public ClienteBL(){
        accesoDatos = new ClienteDA();
    }
    
    public boolean agregarCliente(Cliente c){
        return accesoDatos.agregarCliente(c);
    }
    
    public ArrayList<Cliente> devolverClientes(String id,String nombres, String apellidos, String dni, String telefono, String email, String razon, String ruc){
        return accesoDatos.devolverClientes(id,nombres,apellidos,dni,telefono,email,razon,ruc);
    }
    
}
