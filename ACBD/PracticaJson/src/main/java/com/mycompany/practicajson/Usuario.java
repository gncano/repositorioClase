package com.mycompany.practicajson;

/**
 *
 * @author dam
 */
public class Usuario {
    private String nombre;
    private int edad;
    private String email;

    public Usuario() {
    }
     
    public String getNombre() {
        return nombre;
    }

    public int getEdad() {
        return edad;
    }

    public String getEmail() {
        return email;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    
    
}
