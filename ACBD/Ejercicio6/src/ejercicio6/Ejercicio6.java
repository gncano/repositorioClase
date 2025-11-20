
package ejercicio6;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/**
 *
 * @author dam
 */
public class Ejercicio6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File file = new File("src\\ejercicio6\\Ejercicio6.java");
        File fichero = new File("Ejercicio6.txt");

        leerYmostrar(file);
        escribir(fichero);

    }

    //Lee el fichero java de este ejercicio l?nea por l?nea y mu?stralo por pantalla.
    private static void leerYmostrar(File file) {
        try {
            BufferedReader in = new BufferedReader(new FileReader(file));
            String linea;
            while ((linea = in.readLine()) != null) {
                System.out.print((String) linea + "\n");
            }
            in.close();

        } catch (IOException e) {
            System.out.println("Error");
        }
    }

    private static void escribir(File file) {
        try {
            BufferedWriter out = new BufferedWriter(new FileWriter(file));
            
            for (int i = 1; i < 11; i++) {
                out.write("Fila numero "+i);
                out.newLine();
            }
            out.close();
            

        } catch (IOException e) {
            System.out.println("Error");
        }
    }
}
