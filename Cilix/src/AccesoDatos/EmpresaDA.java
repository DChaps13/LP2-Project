/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Empresa;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

/**
 *
 * @author Sony
 */
public class EmpresaDA {
    
    public EmpresaDA(){}
    
    public boolean agregarEmpresa(Empresa e){
        //
        return true;
    }
    
    public boolean eliminarEmpresa(int id){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            String sentence = "{call dbo.eliminarEmpresa(?)}";
            PreparedStatement ps = conn.prepareStatement(sentence);
            ps.setInt(1,id);
            ps.execute();
            conn.close();
            return true;
        }catch(Exception ex){
            System.out.println("Hubieron problemas con la base de datos");
        }
        return false;
    }
    
    public ArrayList<Empresa> devolverEmpresas(String rSocial,String ruc){
        ArrayList<Empresa> empresas = new ArrayList<Empresa>();
        try{
            
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            String buscaProveedor = "{call dbo.buscarProveedor(?,?)}";
            PreparedStatement ps = conn.prepareStatement(buscaProveedor);
            ps.setString(1, rSocial);
            ps.setString(2, ruc);
            
            ResultSet rs = ps.executeQuery();
            
            while(rs.next()){
                Empresa e = new Empresa();
                e.setRazonSocial(rs.getString("RazonSocial"));
                e.setRuc(rs.getString("RUC"));
                e.setEmail(rs.getString("Correo"));
                empresas.add(e);
            }
        }
        catch(Exception e){}
        
        return empresas;
    }
}
