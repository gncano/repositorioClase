package ejercicio2;

import java.io.File;

public class Ejercicio2 {

    //metodos de la libreria File sencillos para directorios
    public static void main(String[] args) {

        File directorioActual = new File(".");

        File[] lista = directorioActual.listFiles();

        if (lista != null) {
            System.out.println("Número de ficheros y/o directorios en el directorio actual: " + lista.length);

            for (int i = 0; i < lista.length; i++) {
                String tipo = lista[i].isDirectory() ? "Directorio" : "Fichero";
                long tamaño = lista[i].length();
                System.out.println(tipo + ": " + lista[i].getName() + "  Tamaño: " + tamaño + " bytes");
            }
        } else {
            System.out.println("No se ha podido acceder al directorio actual.");
        }
    }

}
