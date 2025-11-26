package ejer2_gonzalocanosebastian;

import java.io.File;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/**
 *
 * @author dam
 */
public class Ejer2_GonzaloCanoSebastian {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            // Crear objeto Comida
            Comida comida = new Comida();
            

            // Crear el parser SAX
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            // Crear el manejador y procesar el XML
            ManejadorComidas manejador = new ManejadorComidas(comida);

            saxParser.parse("MenuCompleto.xml", manejador);

            System.out.println("Datos leidos");

            ficheroTexto(comida);
            System.out.println("Fichero de texto creado");
            ficheroBinario(comida);
            System.out.println("Fichero binario creado");

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //como no he podido hacer bien el parse solo me sale una comida por lo que hago este ejercicio solo con una
    //pero para hacerlo bien habría que recorrer todas comprobando su precio
    private static void ficheroTexto(Comida comida) {
        File fichero = new File("MenuFinal.txt");

        try (FileWriter escribirFichero = new FileWriter(fichero)) {

            if (comida.getPrecio() <= 6.9) {
                escribirFichero.write("Descripcion: " + comida.getDescripcion() + "\nCalorias: " + comida.getCalorias() + "\nPrecio: " + comida.getPrecio());
                escribirFichero.close();
            }
        } catch (IOException e) {
            System.out.println("Error al escribir en el fichero: " + e.getMessage());
        }
    }

    //Lo mismo que en el ejercicio anterior, solo lo puedo hacer con una
    private static void ficheroBinario(Comida comida) {
        File fichero = new File("Calorias.bin");

        try {
            FileOutputStream fos = new FileOutputStream(fichero);
            if (comida.getPrecio() <= 6.9) {
                fos.write(comida.getCalorias());
            }

        } catch (IOException e) {
            System.out.println("Error");
        }
    }

}
