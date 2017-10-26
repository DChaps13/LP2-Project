
package Modelo;

public class Empresa extends Cliente{
    private String razonSocial;
    private String ruc;
    
    private Empresa(){}
    
    private Empresa(String direccion, String telefono, String email, String razonSocial, String ruc){
        super(direccion,telefono,email);
        this.razonSocial = razonSocial;
        this.ruc = ruc;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }
    
    
}
