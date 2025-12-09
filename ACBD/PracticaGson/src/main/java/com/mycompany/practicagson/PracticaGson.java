package com.mycompany.practicagson;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.reflect.TypeToken;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author dam
 */
public class PracticaGson {

    public static void main(String[] args) {
        escribirDatosGson();
        leerDatosGson();
    }

    private static void escribirDatosGson() {
        try {
            List<Usuario> usuarios = new ArrayList<>();
            usuarios.add(new Usuario("Usuario 1", 25, "usuario1@gmail.com"));
            usuarios.add(new Usuario("Usuario 2", 30, "usuario2@gmail.com"));
            usuarios.add(new Usuario("Usuario 3", 28, "usuario3@gmail.com"));

            Gson gson = new GsonBuilder().setPrettyPrinting().create();

            try (FileWriter writer = new FileWriter("usuarios.json")) {
                gson.toJson(usuarios, writer);
            }

            System.out.println("Archivo creado ");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void leerDatosGson() {
        try {
            Gson gson = new Gson();
            Type listType = new TypeToken<List<Usuario>>() {}.getType();

            try (FileReader reader = new FileReader("usuarios.json")) {
                List<Usuario> usuarios = gson.fromJson(reader, listType);

                for (Usuario u : usuarios) {
                    System.out.println("Nombre: " + u.getNombre());
                    System.out.println("Edad: " + u.getEdad());
                    System.out.println("Email: " + u.getEmail());
                    System.out.println("---------------------------");
                }
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
        
        }
    }

