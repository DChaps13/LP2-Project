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
    
    public ArrayList<Cliente> devolverClientes(String id, String telefono, String email){
        return accesoDatos.devolverClientes(id,telefono,email);
    }
    
}
