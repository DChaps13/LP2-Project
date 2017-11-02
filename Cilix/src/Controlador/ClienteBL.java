/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.ClienteDA;
import Modelo.Cliente;

/**
 *
 * @author Emanuel
 */
public class ClienteBL {
    
    ClienteDA accesoDatos;
    
    public ClienteBL(){
        accesoDatos = new ClienteDA();
    }
    
    public void agregarCliente(Cliente c){
        accesoDatos.agregarCliente(c);
    }
}
