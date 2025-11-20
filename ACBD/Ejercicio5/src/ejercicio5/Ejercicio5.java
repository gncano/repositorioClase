package ejercicio5;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

/**
 *
 * @author dam
 */
public class Ejercicio5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        File fichero = new File("FICHTEXTO.txt");

        try (FileWriter escribirFichero = new FileWriter(fichero)) {

            escribirFichero.write("Esto es una prueba de escribir cadenas de caracteres en un fichero de texto\n");
            escribirFichero.close();
        } catch (IOException e) {
            System.out.println("Error al escribir en el fichero: " + e.getMessage());
        }

        try (FileWriter escribirFichero2 = new FileWriter(fichero, true)) {

            escribirFichero2.write("Gonzalo Cano Sebastian\n");
            escribirFichero2.close();
        } catch (IOException e) {
            System.out.println("Error al añadir al fichero: " + e.getMessage());
        }

    }

}
