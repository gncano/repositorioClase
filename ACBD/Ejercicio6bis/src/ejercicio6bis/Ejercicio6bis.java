package ejercicio6bis;
//Prueba para el reset
import java.io.*;

/**
 *
 * @author dam
 */
public class Ejercicio6bis {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File file = new File("src\\ejercicio6bis\\Ejercicio6bis.java");
        File fichero = new File("Ejercicio6bis.txt");

        try {
            if (fichero.exists()) {
                System.out.println("El fichero ya existe");
            } else {
                System.out.println("Fichero creado");
                fichero.createNewFile();
            }
        } catch (IOException e) {
            System.out.println("error");
        }

        System.out.println("\n----------------------------------------------------------");
        leerFchero(file);
        System.out.println("\n----------------------------------------------------------");
        escribirfichero(fichero);
        System.out.println("\n----------------------------------------------------------");
    }

    private static void leerFchero(File fichero) {
        try (BufferedReader br = new BufferedReader(new FileReader(fichero))) {

            // comprueba si el flujo está listo para ser leído
            if (br.ready()) {
                System.out.println("El fichero esta listo para leerse.");
            }else{
                System.out.println("El fichero no esta listo para leerse");
            }

            // mark() y reset(): permiten volver a una posición marcada
            String linea1 = br.readLine();
            System.out.println("\nLeido antes del mark: " + linea1);
            br.mark(100); // marca el punto al que se vuelve con el reset
            String linea2 = br.readLine();
            System.out.println("Leido despues del mark:  " + linea2);

            String linea3 = br.readLine();
            System.out.println("Siguiente linea: " + linea3);

            br.reset(); // vuelve al punto marcado
            System.out.println("De nuevo a la marca: " + br.readLine());
            br.close();

        } catch (IOException e) {
            System.out.println("error");
        }
    }

    private static void escribirfichero(File fichero) {
        try (BufferedWriter bw = new BufferedWriter(new FileWriter(fichero))) {
            // añade texto al buffer, es parecido al write
            bw.append("Primera línea con append() \n");
            bw.append("Segunda línea con append()");

            // fuerza a que el buffer se vacíe en el fichero inmediatamente
            bw.flush();
            System.out.println("Texto escrito con append() y guardado con flush().");
            bw.close();
        } catch (IOException e) {
            System.out.println("error");
        }
    }
}
