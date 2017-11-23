/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.RolUsuario;
import Modelo.TransaccionTipo;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class TransaccionTipoDA {

    public ArrayList<TransaccionTipo> devolverTipos() {
        ArrayList<TransaccionTipo> tipos = new ArrayList<TransaccionTipo>();
        
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            String buscarTipos = "{call dbo.listarTipos()}";
            PreparedStatement ps = conn.prepareStatement(buscarTipos);     
            
            ResultSet rs = ps.executeQuery();
            ArrayList<TransaccionTipo> lista  = new ArrayList<TransaccionTipo>();
            
            while(rs.next()){
                TransaccionTipo t = new TransaccionTipo();
                t.setId(rs.getInt("Id"));
                t.setDescriptor(rs.getString("Descriptor"));
                t.setSigno(rs.getString("Signo").charAt(0));
                lista.add(t);
            }
            conn.close();
            return lista;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    
    }
    
    public TransaccionTipo getTransaccionTipobyId(int idTipo){
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            ResultSet rsId;
            
            TransaccionTipo tipo = new TransaccionTipo();
            String query = "SELECT * FROM dbo.TipoTransaccion WHERE Id = ";
            query += Integer.toString(idTipo);
            rsId=sentencia.executeQuery(query);
            rsId.next();
            tipo.setId(rsId.getInt("Id"));
            tipo.setDescriptor(rsId.getString("Descriptor"));
            char[] cbuf = new char[1];
            rsId.getCharacterStream("Signo").read(cbuf);
            tipo.setSigno(cbuf[0]);
            
            return tipo;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
}
