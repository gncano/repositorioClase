package ejercicio1;

import java.io.File;

/**
 *
 * @author dam
 */
public class Ejercicio1 {

    //metodos de la libreria File sencillos para archivos
    public static void main(String[] args) {
        File fichero = new File("alumno.xml");

        System.out.println("Nombre: " + fichero.getName());
        System.out.println("Padre: " + fichero.getParent());
        System.out.println("Ruta relativa: " + fichero.getPath());
        System.out.println("Ruta absoluta: " + fichero.getAbsolutePath());

        if (fichero.exists()) {
            System.out.println("El fichero alumno.xml existe");
            informacionFichero(fichero);
        } else {
            System.out.println("El fichero alumno.xml no existe");
        }

    }

    private static void informacionFichero(File fichero) {
        System.out.println("Se puede leer? " + (fichero.canRead() ? "Si" : "No"));
        System.out.println("Se puede escribir? " + (fichero.canWrite() ? "Si" : "No"));
        System.out.println("Tamaño: " + fichero.length());
    }

}
