/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Cliente;
import Modelo.ClienteNatural;
import Modelo.Empresa;
import Modelo.Producto;
import Modelo.Transaccion;
import Modelo.TransaccionTipo;
import Modelo.Usuario;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author Emanuel
 */
public class TransaccionDA {
    
    public TransaccionDA(){}
    
    public boolean registrarTransaccion(Transaccion t){
         try {
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            String insertar = "{call dbo.insertarTransaccion(?,?,?,?,?,?,?)}";
            PreparedStatement ps = conn.prepareStatement(insertar);
            
            ps.setInt(1,t.getCantidad());         
            ps.setInt(2, t.getTipoTransaccion().getId());
            ps.setInt(3, t.getEmpresa().getId());
            ps.setInt(4, t.getClienteNatural().getId());
            ps.setString(5,t.getDescripcion());
            ps.setInt(6, t.getProducto().getId());
            ps.setString(7, t.getUsuario().getId());    
            ps.execute();
            
            String actualizarCantidad = "{call dbo.actualizarCantidadProducto(?,?)}";
            PreparedStatement ps2 = conn.prepareStatement(actualizarCantidad);
            
            ps2.setInt(1,t.getProducto().getId());
            if(t.getTipoTransaccion().getDescriptor().equals("Compra")){
                ps2.setInt(2,t.getCantidad()*-1);
            }
            else{
                ps2.setInt(2, t.getCantidad());
            }
            
            ps2.execute();           
            
            
            return true;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return false;
    }   
    
    
    public ArrayList<Transaccion> devolverTransacciones(ArrayList<Cliente> clientes, ArrayList<Producto> productos, ArrayList<Usuario> usuarios ){
        ArrayList<Transaccion> lista = new ArrayList<Transaccion>();
//        try{    
//            //registrar el Driver 
//            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
//            //establecer la conexión
//            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
//                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
//            
//            Statement sentencia=conn.createStatement();
//            
//            // formar query
//            String query = "SELECT * FROM Transacción ";
//            String extra = "";
//            
//            if(clientes.size() > 0){
//                extra = extra + " ( ";
//                for(int i = 0; i < clientes.size(); ++i){
//                    if(i > 0) extra = extra + " OR ";
//                    extra = extra + " Id_Usuario =  " + "'" + clientes.get(i).getId() + "' ";
//                }
//                extra = extra + " ) ";
//            }
//            
//            if(productos.size() > 0){
//                if(!extra.equals("")) extra = extra + " AND ";
//                extra = extra + " ( ";
//                for(int i = 0; i < productos.size(); ++i){
//                    if(i > 0) extra = extra + " OR ";
//                    extra = extra + " Id_Producto = " + "'" + productos.get(i).getId() + "' ";
//                }
//                extra = extra + " ) ";
//            }
//            
//            if(usuarios.size() > 0){
//                if(!extra.equals("")) extra = extra + " AND ";
//                extra = extra + " ( ";
//                for(int i = 0; i < usuarios.size(); ++i){
//                    if(i > 0) extra = extra + " OR ";
//                    extra = extra + " Id_Usuario = " + "'" + usuarios.get(i).getId() + "' ";
//                }
//                extra = extra + " ) ";
//            }
//            //Esto lo hizo chapi
//            if (extra != "") query = query + " WHERE " + extra;
//            ResultSet rs = sentencia.executeQuery(query);
//            while(rs.next()){
//                Transaccion t = new Transaccion();
//                /* SOLO FALTA EXTRAER DATOS DE TRANSACCION */
//                //Esto lo hizo chapi
//                int id = rs.getInt("Id");
//                int cantidad = rs.getInt("cantidad");
//                String descp = rs.getString("Descripción");
//                String destino = rs.getString("Destino");
//                Date fecha = rs.getDate("Fecha");
//                int idCont = rs.getInt("Id_Contacto");
//                int idTipo = rs.getInt("Id_Tipo_Transaccion");
//                int idProd = rs.getInt("Id_Producto");
//                String idUsu = rs.getString("Id_Usuario");
//                t.setId(id);
//                t.setCantidad(cantidad);
//                t.setDescripcion(descp);
//                t.setDestino(destino);
//                t.setFecha(fecha);
//                t.setIdContacto(idCont);
//                t.setIdProducto(idProd);
//                t.setIdTipoTransaccion(idTipo);
//                t.setIdUsuario(idUsu);
//                lista.add(t);
//            }
//            conn.close();
//            return lista;
//        }catch (Exception e){
//            // do something appropriate with the exception, *at least*:
//            System.out.println(e.getMessage());
//        }
        
        return null; 
    }
}
