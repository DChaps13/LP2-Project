/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.sql.Date;

/**
 *
 * @author Emanuel
 */
public class Transaccion {

    /**
     * @return the clienteNatural
     */
    public ClienteNatural getClienteNatural() {
        return clienteNatural;
    }

    /**
     * @param clienteNatural the clienteNatural to set
     */
    public void setClienteNatural(ClienteNatural clienteNatural) {
        this.clienteNatural = clienteNatural;
    }

    /**
     * @return the empresa
     */
    public Empresa getEmpresa() {
        return empresa;
    }

    /**
     * @param empresa the empresa to set
     */
    public void setEmpresa(Empresa empresa) {
        this.empresa = empresa;
    }

    /**
     * @return the tipoTransaccion
     */
    public TransaccionTipo getTipoTransaccion() {
        return tipoTransaccion;
    }

    /**
     * @param tipoTransaccion the tipoTransaccion to set
     */
    public void setTipoTransaccion(TransaccionTipo tipoTransaccion) {
        this.tipoTransaccion = tipoTransaccion;
    }

    /**
     * @return the producto
     */
    public Producto getProducto() {
        return producto;
    }

    /**
     * @param producto the producto to set
     */
    public void setProducto(Producto producto) {
        this.producto = producto;
    }
    
    private int id;
    private int cantidad;
    private String descripcion;
    private ClienteNatural clienteNatural;
    private Empresa empresa;
    private Date fecha;
    private TransaccionTipo tipoTransaccion;
    private Producto producto;
    private Usuario usuario; 
    
    public Transaccion(){
        this.descripcion = "No c dice";
        this.clienteNatural = new ClienteNatural();
        this.empresa = new Empresa();
        this.tipoTransaccion  = new TransaccionTipo();
        this.producto = new Producto();
        this.usuario = new Usuario();
    }

    public Usuario getUsuario() {
        return usuario;
    }

    public void setUsuario(Usuario usuario) {
        this.usuario = usuario;
    }

    
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }


    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    
    
    
}
