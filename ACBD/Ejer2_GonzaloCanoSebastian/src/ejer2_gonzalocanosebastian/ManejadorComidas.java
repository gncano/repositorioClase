package ejer2_gonzalocanosebastian;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author dam
 */
public class ManejadorComidas extends DefaultHandler {

    private StringBuilder valorActual;
    private Comida comida;
    private boolean enComida=false;

    public ManejadorComidas(Comida comida) {
        this.comida = comida;

        this.valorActual = new StringBuilder();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        valorActual.setLength(0);
        enComida=true;

    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        valorActual.append(ch, start, length);
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        
        switch (qName.toLowerCase()) {
            case "nombre":
                comida.setNombre(valorActual.toString().trim());
                break;
            case "precio":
                comida.setPrecio(Float.parseFloat(valorActual.toString().trim()));
                break;
            case "descripcion":
                comida.setDescripcion(valorActual.toString().trim());
                break;
            case "calorias":
                comida.setCalorias(Integer.parseInt(valorActual.toString().trim()));
                enComida=false;
                break;
        }

    }
}
