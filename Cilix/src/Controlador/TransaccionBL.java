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
import Modelo.TransaccionTipo;
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
    
    public boolean registrarTransaccion(Transaccion t){
        return accesoDatos.registrarTransaccion(t);
    }
    public ArrayList<Transaccion> devolverTransacciones(ArrayList<Cliente> clientes, ArrayList<Producto> productos, ArrayList<Usuario> usuarios ){
        return accesoDatos.devolverTransacciones(clientes, productos, usuarios);
   }
}
