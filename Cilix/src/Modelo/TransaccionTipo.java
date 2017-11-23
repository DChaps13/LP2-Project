/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author alulab14
 */
public class TransaccionTipo {

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     * @return the descriptor
     */
    public String getDescriptor() {
        return descriptor;
    }

    /**
     * @param descriptor the descriptor to set
     */
    public void setDescriptor(String descriptor) {
        this.descriptor = descriptor;
    }

    /**
     * @return the signo
     */
    public char getSigno() {
        return signo;
    }

    /**
     * @param signo the signo to set
     */
    public void setSigno(char signo) {
        this.signo = signo;
    }
    private int id;
    private String descriptor;
    private char signo;
    
    
}
