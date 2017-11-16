/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.TransaccionDA;
import Modelo.Transaccion;

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
    
}
