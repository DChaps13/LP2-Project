
package Modelo;

public class Empresa extends Cliente{
    private String razonSocial;
    private String ruc;
    private String tipo;
    
    public Empresa(){}
    
    public Empresa(String telefono, String email, String razonSocial, String ruc, String tipo){
        super(telefono,email);
        this.razonSocial = razonSocial;
        this.ruc = ruc;
        this.tipo= tipo;
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

    /**
     * @return the tipo
     */
    public String getTipo() {
        return tipo;
    }

    /**
     * @param tipo the tipo to set
     */
    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    
    
}
