package com.mycompany.practicajson;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author dam
 */
public class PracticaJson {

    public static void main(String[] args) {
        escribirDatosJson();
        leerDatosJson();
    }

    private static void escribirDatosJson() {
        try {
            ObjectMapper objectMapper = new ObjectMapper();

            Usuario usuario1 = new Usuario();
            usuario1.setNombre("Usuario 1");
            usuario1.setEdad(25);
            usuario1.setEmail("usuario1@gmail.com");

            Usuario usuario2 = new Usuario();
            usuario2.setNombre("Usuario 2");
            usuario2.setEdad(30);
            usuario2.setEmail("usuario2@gmail.com");

            Usuario usuario3 = new Usuario();
            usuario3.setNombre("Usuario 3");
            usuario3.setEdad(28);
            usuario3.setEmail("usuario3@gmail.com");

            List<Usuario> usuarios = new ArrayList<>();
            usuarios.add(usuario1);
            usuarios.add(usuario2);
            usuarios.add(usuario3);

            objectMapper.writeValue(new File("usuarios.json"), usuarios);

            System.out.println("Archivo creado");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void leerDatosJson() {
        try {
            ObjectMapper objectMapper = new ObjectMapper();

            List<Usuario> usuarios = objectMapper.readValue(
                    new File("usuarios.json"),
                    new TypeReference<List<Usuario>>() {
            }
            );

            for (Usuario usuario : usuarios) {
                System.out.println("Nombre: " + usuario.getNombre());
                System.out.println("Edad: " + usuario.getEdad());
                System.out.println("Email: " + usuario.getEmail());
                System.out.println("---------------------------------");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
