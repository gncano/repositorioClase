package ejercicio7;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 *
 * @author dam
 */
public class Ejercicio7 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File fichero = new File("numeros.bin");

        // 1) Escribir los 5 primeros números 
        try {
            FileOutputStream fos = new FileOutputStream(fichero);
            for (int i = 1; i <= 5; i++) {
                fos.write(i);
            }
            System.out.println("Fichero 'numeros.bin' creado y numeros escritos correctamente.");
        } catch (IOException e) {
            System.out.println("Error");
        }

        // 2) Leer los números del fichero y mostrarlos por consola
        try {
            FileInputStream fis = new FileInputStream(fichero);
            System.out.println(fis.read());
            System.out.println(fis.read());
            System.out.println(fis.read());
            System.out.println(fis.read());
            System.out.println(fis.read());
            
        } catch (IOException e) {
            System.out.println("Error");
        }
    }
}
