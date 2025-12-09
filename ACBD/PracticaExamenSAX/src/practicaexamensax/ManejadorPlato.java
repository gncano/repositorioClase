package practicaexamensax;

import java.util.ArrayList;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author gcano
 */
public class ManejadorPlato extends DefaultHandler{

    ArrayList<Plato> platos = new ArrayList<>();
    private Plato plato;
    private StringBuilder valorActual;

    public ManejadorPlato() {
        
        this.valorActual = new StringBuilder();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
       valorActual.setLength(0);
        
        if (qName.equalsIgnoreCase("Plato")) { 
            plato= new Plato();
            String id = attributes.getValue("id");
            plato.setId(id);
        }
    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        valorActual.append(ch, start, length);
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        switch (qName.toLowerCase()) {
            case "nombre" -> plato.setNombre(valorActual.toString().trim());
            case "precio" -> plato.setPrecio(Float.parseFloat(valorActual.toString().trim()));
            case "tipo" -> plato.setTipo(valorActual.toString().trim());
            case "ingredientes" -> plato.setIngredientes(valorActual.toString().trim());
            case "plato" -> platos.add(plato);
        }
    }

    public ArrayList<Plato> getPlatos() {
        return platos;
    }
    
   
}
