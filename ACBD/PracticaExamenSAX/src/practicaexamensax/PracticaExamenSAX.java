package practicaexamensax;

import java.io.BufferedWriter;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/**
 *
 * @author gcano
 */
public class PracticaExamenSAX {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {

            // Crear el parser SAX
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            // Crear el manejador y procesar el XML
            ManejadorPlato manejador = new ManejadorPlato();
            saxParser.parse("Platos.xml", manejador);

            // Mostrar los datos leídos
            System.out.println("Datos del plato leidos del XML:");
            System.out.println(manejador.getPlatos());

            guardarPostres(manejador.getPlatos());

            guardarPlatosBinario(manejador.getPlatos());
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    private static void guardarPostres(ArrayList<Plato> platos) {

        File archivo = new File("Postres.txt");

        try (BufferedWriter bw = new BufferedWriter(new FileWriter(archivo))) {
            for (Plato plato : platos) {
                if (plato.getTipo().equalsIgnoreCase("Postre")) {
                    String linea = "Nombre: " + plato.getNombre() + " | Precio: " + plato.getPrecio() + "€ | Ingredientes: " + plato.getIngredientes();
                    bw.write(linea);
                    bw.newLine();
                }
            }
            System.out.println("Archivo 'Postres.txt' creado correctamente.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void guardarPlatosBinario(ArrayList<Plato> platos) {
        try (DataOutputStream dos = new DataOutputStream(new FileOutputStream("PlatosBinario.dat"))) {
            for (Plato plato : platos) {
                if (plato.getPrecio() > 6f) {
                    dos.writeUTF(plato.getNombre());
                    dos.writeDouble(plato.getPrecio());
                    dos.writeUTF(plato.getTipo());
                    dos.writeUTF(plato.getIngredientes());
                }
            }
            System.out.println("Archivo 'PlatosBinario.dat' creado correctamente.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
