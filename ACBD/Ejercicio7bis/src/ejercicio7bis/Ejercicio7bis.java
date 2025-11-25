package ejercicio7bis;

import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;

/**
 *
 * @author dam
 */
public class Ejercicio7bis {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File fichero = new File("datos.bin");

        try (RandomAccessFile raf = new RandomAccessFile(fichero, "rw")) {

            // Escribir 5 enteros en el fichero
            for (int i = 1; i <= 5; i++) {
                raf.writeInt(i); 
            }
            System.out.println("Fichero 'datos.bin' creado con 5 numeros enteros.\n");

            // Leer el tercer número sin recorrer todo el fichero
            long posicionTercerNumero = 8; // tercera posición, 8 byte.
            raf.seek(posicionTercerNumero); // mueve el puntero al tercer número.
            int numeroLeido = raf.readInt();
            System.out.println("El numero leido es: " + numeroLeido);

            // Modificar el cuarto número 
            long posicionCuartoNumero = (12); // cuarta posicion, byte 12
            raf.seek(posicionCuartoNumero);
            raf.writeInt(999); // sustituye el numero 4 por 999
            System.out.println("Se ha modificado el cuarto numero a 999.\n");

            // Mostrar todo el contenido del fichero después del cambio
            System.out.println("Contenido completo del fichero tras la modificacion:");
            raf.seek(0); // volver al inicio
            for (int i = 0; i < 5; i++) {
                System.out.println("Numero " + (i + 1) + ": " + raf.readInt());
            }

        } catch (IOException e) {
            System.out.println("Error al acceder al fichero: " + e.getMessage());
        }
    }
}