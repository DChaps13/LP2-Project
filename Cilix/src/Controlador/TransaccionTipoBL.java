/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import AccesoDatos.TransaccionTipoDA;
import Modelo.TransaccionTipo;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class TransaccionTipoBL {
    TransaccionTipoDA accesoDatosTipo = new TransaccionTipoDA();
    
    public ArrayList<TransaccionTipo> devolverTipos(){
        return accesoDatosTipo.devolverTipos();
    }
    
}
