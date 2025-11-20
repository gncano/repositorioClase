package practicasax;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class ManejadorLibro extends DefaultHandler {

    private Libro libro;
    private StringBuilder valorActual;

    public ManejadorLibro(Libro libro) {
        this.libro = libro;
        this.valorActual = new StringBuilder();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        valorActual.setLength(0); 
        if (qName.equalsIgnoreCase("libro")) {
            String isbn = attributes.getValue("isbn");
            libro.setIsbn(isbn);
        }
    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        valorActual.append(ch, start, length);
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        switch (qName.toLowerCase()) {
            case "titulo":
                libro.setTitulo(valorActual.toString().trim());
                break;
            case "autor":
                libro.setAutor(valorActual.toString().trim());
                break;
            case "anyo":
                libro.setAnyo(Integer.parseInt(valorActual.toString().trim()));
                break;
            case "editorial":
                libro.setEditorial(valorActual.toString().trim());
                break;
        }
    }
}
