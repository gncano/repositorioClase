package practicasax;

import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author dam
 */
public class PracticaSAX {


    public static void main(String[] args) {
        try {
            // Crear objeto Libro
            Libro libro = new Libro();

            // Crear el parser SAX
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            // Crear el manejador y procesar el XML
            ManejadorLibro manejador = new ManejadorLibro(libro);
            saxParser.parse("Fichero.xml", manejador);

            // Mostrar los datos leídos
            System.out.println("Datos del libro leidos del XML:");
            System.out.println(libro);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}