/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package ejercicio3;

import java.io.*;

/**
 *
 * @author dam
 */
public class Ejercicio3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File nuevoDir = new File("NUEVODIR");

        if (nuevoDir.exists()) {
            System.out.println("Directorio ya existente");
        } else {
            nuevoDir.mkdir();
            System.out.println("Directorio creado");
        }

        File f1 = new File(nuevoDir, "FICHERO1.txt");
        File f2 = new File(nuevoDir, "FICHERO2.txt");

        if (f1.exists()) {
            System.out.println("f1 ya exitente");
        } else {
            f1.mkdir();
            System.out.println("f1 creado");
        }

        if (f2.exists()) {
            System.out.println("f2 ya exitente");
        } else {
            f2.mkdir();
            System.out.println("f2 creado");
        }

        File nuevoNombre = new File(nuevoDir, "FICHERO1NUEVO");
        f1.renameTo(nuevoNombre);

        f2.delete();
        if (f2.exists()) {
            System.out.println("f2 no se ha borrado");
        } else {
            System.out.println("f2 se ha borrado correctamente");
        }
    }
}
