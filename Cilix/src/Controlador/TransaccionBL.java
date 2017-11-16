/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.TransaccionDA;
import Modelo.Cliente;
import Modelo.Producto;
import Modelo.Transaccion;
import Modelo.Usuario;
import java.util.ArrayList;

/**
 *
 * @author Emanuel
 */
public class TransaccionBL {
    TransaccionDA accesoDatos;
    
    public TransaccionBL(){
        accesoDatos = new TransaccionDA();
    }
    
    public boolean registrarVenta(Transaccion t){
        return accesoDatos.registrarVenta(t);
    }
    public ArrayList<Transaccion> devolverTransacciones( ArrayList<Cliente> clientes, ArrayList<Producto> productos, ArrayList<Usuario> usuarios ){
        return accesoDatos.devolverTransacciones(clientes, productos, usuarios);
    }
}
