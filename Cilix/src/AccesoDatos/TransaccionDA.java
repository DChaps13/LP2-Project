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
            
            conn.close();
            return true;
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return false;
    }   
    
    
    public ArrayList<Transaccion> devolverTransacciones(ArrayList<Cliente> clientes, ArrayList<Producto> productos, ArrayList<Usuario> usuarios ){
        ArrayList<Transaccion> lista = new ArrayList<Transaccion>();
        try{    
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            
            Statement sentencia=conn.createStatement();
            
            // formar query
            String query = "SELECT * FROM Transacción";
            String extra1 = "";
            String extra2 = "";
            String extra3 = "";
            
            if(clientes.size() > 0){
                extra1 = extra1 + " ( ";
                for(int i = 0; i < clientes.size(); ++i){
                    if(i > 0) extra1 = extra1 + " OR ";
                    Cliente c=clientes.get(i);
                    if(c instanceof ClienteNatural)
                        extra1 = extra1 + " Id_ClienteNatural =  " + "'" + c.getId() + "' ";
                    else
                        extra1 = extra1 + " Id_Empresa =  " + "'" + c.getId() + "' ";
                }
                extra1 = extra1 + " ) ";
            }
            
            if(productos.size() > 0){
                extra2 = extra2 + " ( ";
                for(int i = 0; i < productos.size(); ++i){
                    if(i > 0) extra2 = extra2 + " OR ";
                    extra2 = extra2 + " Id_Producto = " + "'" + productos.get(i).getId() + "' ";
                }
                extra2 = extra2 + " ) ";
            }
            
            if(usuarios.size() > 0){
                extra3 = extra3 + " ( ";
                for(int i = 0; i < usuarios.size(); ++i){
                    if(i > 0) extra3 = extra3 + " OR ";
                    extra3 = extra3 + " Id_Usuario = " + "'" + usuarios.get(i).getId() + "' ";
                }
                extra3 = extra3 + " ) ";
            }
            if (extra1 != "") {
                query += " WHERE " + extra1;
                if(extra2 != ""){
                    query += " INTERSECT " + "SELECT * FROM Transacción" + " WHERE " + extra2;                    
                }
                if(extra3 != ""){
                    query += " INTERSECT " + "SELECT * FROM Transacción" + " WHERE " + extra3;
                }
            }
            else{
                if(extra2 != ""){
                    query += " WHERE " + extra2;
                    if(extra3 != ""){
                        query += " INTERSECT " + "SELECT * FROM Transacción" + " WHERE " + extra3;
                    }
                }
                else{
                    if(extra3 != ""){
                        query += " WHERE " + extra3;
                    }
                }
            }
            ResultSet rs = sentencia.executeQuery(query);
            while(rs.next()){
                
                /* SOLO FALTA EXTRAER DATOS DE TRANSACCION */
                
                //Datos del query de transaccion
                int id = rs.getInt("Id");
                int cantidad = rs.getInt("cantidad");
                String descripcion = rs.getString("Descripción");
//                String destino = rs.getString("Destino");
                Date fecha = rs.getDate("Fecha");
                int idCliente = rs.getInt("Id_ClienteNatural");
                int idEmpresa = rs.getInt("Id_Empresa");
                int idTipo = rs.getInt("Id_Tipo_Transaccion");
                int idProd = rs.getInt("Id_Producto");
                String idUsu = rs.getString("Id_Usuario");
                
                //Armar una transacción a partir de los IDs
                Transaccion t = new Transaccion();
                t.setId(id);
                t.setCantidad(cantidad);
                t.setDescripcion(descripcion);
//                t.setDestino(destino);
                t.setFecha(fecha);
                
                //Porque chapi esta manejando la no-existencia de un foreign key con 
                //una empresa o persona "FANTASMA" de id 9 (porque en una transacción
                //el destino es o una persona natural o una empresa, nunca ambos y uno debería ser null)
                ResultSet rsId;
                if(idCliente!=9){
                    ClienteNaturalDA cnDA = new ClienteNaturalDA();
                    t.setClienteNatural(cnDA.getClientbyID(idCliente));
                    t.setEmpresa(null);
                }
                else{
                    EmpresaDA eDA = new EmpresaDA();
                    t.setClienteNatural(null);
                    t.setEmpresa(eDA.getEmpresabyId(idEmpresa));
                }
                
                ProductoDA pDA = new ProductoDA();
                t.setProducto(pDA.getProductobyId(idProd));
                
                TransaccionTipoDA ttDA = new TransaccionTipoDA();
                t.setTipoTransaccion(ttDA.getTransaccionTipobyId(idTipo));
                
                UsuarioDA uDA = new UsuarioDA();
                t.setUsuario(uDA.getUsuariobyId(idUsu));

                lista.add(t);
            }
            conn.close();
            return lista;
        }catch (Exception e){
            // do something appropriate with the exception, *at least*:
            System.out.println(e.getMessage());
        }
        
        return null; 
    }
}
