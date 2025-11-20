package ejercicio4;

import java.io.File;
import java.io.FileReader;
import java.io.IOException;

/**
 *
 * @author dam
 */
public class Ejercicio4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String ruta = "src\\ejercicio4\\Ejercicio4.java";
        File file = new File(ruta);

        mostrarCaracteres(file);
        mostrarCaracteresDe20En20(file);

    }

// 1.- Lee y muestra por pantalla cada uno de los caracteres del fichero java de este mismo ejercicio.
    private static void mostrarCaracteres(File file) {
        try {
            FileReader fr = new FileReader(file);
            int a;
            while ((a = fr.read()) != -1) {
                System.out.print((char) a);
            }
                fr.close();
        } catch (IOException e) {
            System.out.println("Error");
        }
    }

    //2.- Lee y muestra por pantalla de 20 en 20 caracteres el fichero java de este mismo ejercicio.
    private static void mostrarCaracteresDe20En20(File file) {
        try {
            FileReader fr = new FileReader(file);
            int a;
            char[] numCaracteres = new char[20];
            while ((a = fr.read(numCaracteres)) != -1) {
                String salida = new String(numCaracteres,0,a);
                System.out.printf("%s\n---------------------------\n",salida);
            }
                fr.close();
        } catch (IOException e) {
            System.out.println("Error");
        }
    }

}