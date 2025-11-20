package ejercicio3bis;

import java.io.File;

/**
 *
 * @author dam
 */
public class Ejercicio3bis {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File f = new File("f");
        f.mkdir();

        //Llamada a los metodos
        estaOculto(f);
        espacioLibre(f);
        capacidadTotal(f);
    }

    //Comprobar si está oculto en el sistema de archivos
    private static void estaOculto(File f) {
        boolean oculto = f.isHidden();
        System.out.println(oculto ? "Esta oculto" : "No esta oculto");

    }

    //Devuelve el espacio libre
    private static void espacioLibre(File f) {
        float lectura = f.getFreeSpace();
        System.out.println(lectura + " bytes");
    }

    //Devuelve la capacidad total del disco (en bytes) donde está el directorio.
    private static void capacidadTotal(File f) {
        long total = f.getTotalSpace();
        System.out.println("Capacidad total: " + total + " bytes");
    }
}