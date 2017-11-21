/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;
import AccesoDatos.EmpresaDA;
import Modelo.Empresa;
import java.util.ArrayList;

/**
 *
 * @author Sony
 */
public class EmpresaBL {
    
    EmpresaDA accesoDatos;
    
    public EmpresaBL(){
        
        accesoDatos = new EmpresaDA();
        
    }
    
    public boolean agregarEmpresa(Empresa e){
        return accesoDatos.agregarEmpresa(e);
    }
    
    public ArrayList<Empresa> devolverEmpresas(String rSocial,String ruc){
        return accesoDatos.devolverEmpresas(rSocial,ruc);
    }
    
}
