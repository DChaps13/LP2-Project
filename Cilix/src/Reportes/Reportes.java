
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Reportes;

import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JFrame;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import net.sf.jasperreports.view.JasperViewer;


public class Reportes {
    
    public Reportes(){
        
    }
    
    public void productosMasVendidos(){
        try{
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(Reportes.class.getResource("/Reportes/reporteProductos.jasper").getFile());
            JasperPrint print  = JasperFillManager.fillReport(reporte,null,conn);
            JasperViewer v = new JasperViewer(print,false);
            
            v.setTitle("Productos más vendidos");
            v.setVisible(true);
            
        }
        catch(Exception e){
            
        }
    }
    
    public void clientesFrecuentes(){
        try{
            //registrar el Driver 
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //establecer la conexión
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://200.16.7.140; databaseName=inf282g4;"
                    + "integratedSecurity=false;username=inf282g4; password=LnyBcOhGWyvFVtBp;");
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(Reportes.class.getResource("/Reportes/reporteClientes.jasper").getFile());
            JasperPrint print  = JasperFillManager.fillReport(reporte,null,conn);
            JasperViewer v = new JasperViewer(print,false);
            v.setTitle("Clientes frecuentes");
            v.setVisible(true);
        }
        catch(Exception e){
            
        }        
    }    
}

