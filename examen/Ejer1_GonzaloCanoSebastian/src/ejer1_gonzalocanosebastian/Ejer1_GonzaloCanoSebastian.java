package ejer1_gonzalocanosebastian;

import java.io.File;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathFactory;
import org.w3c.dom.Attr;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

/**
 *
 * @author dam
 */
public class Ejer1_GonzaloCanoSebastian {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        File file = crearFichero();
        System.out.println("Archivo Pedidos.xml creado");

        modificarFichero(file);
        System.out.println("Archivo Pedidos.xml modificado");

        File copia = new File("CopiaDePedidos.xml");
      
        copiarNodo(file, copia);
        System.out.println("Nodo pedido copiado al archivo CopiaDePedidos.xml de forma correcta");
    }

    private static File crearFichero() {
        File file = new File("Pedidos.xml");
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document doc = builder.newDocument();

            XPath xPath = XPathFactory.newInstance().newXPath();

            // definimos el elemento raíz del documento
            Element raiz = doc.createElement("Pedidos");
            doc.appendChild(raiz);

            // definimos el nodo que contendrá los elementos
            Element nodo = doc.createElement("Pedido");
            raiz.appendChild(nodo);

            Attr attr = doc.createAttribute("id");
            attr.setValue("121");
            nodo.setAttributeNode(attr);

            // definimos cada uno de los elementos y le asignamos un valor
            Element proveedor = doc.createElement("proveedor");
            proveedor.appendChild(doc.createTextNode("32"));
            nodo.appendChild(proveedor);

            Element nombre = doc.createElement("nombre");
            nombre.appendChild(doc.createTextNode("Entrepinares"));
            nodo.appendChild(nombre);

            Element producto = doc.createElement("producto");
            producto.appendChild(doc.createTextNode("Queso curado"));
            nodo.appendChild(producto);

            Element cantidad = doc.createElement("cantidad");
            cantidad.appendChild(doc.createTextNode("100"));
            nodo.appendChild(cantidad);

            Element precio = doc.createElement("precio");
            precio.appendChild(doc.createTextNode("500"));
            nodo.appendChild(precio);

            //definimos el nodo2
            Element nodo2 = doc.createElement("Pedido");
            raiz.appendChild(nodo2);

            Attr attr2 = doc.createAttribute("id");
            attr2.setValue("122");
            nodo2.setAttributeNode(attr2);

            //definimos los elementos del nodo2
            Element proveedor2 = doc.createElement("proveedor");
            proveedor2.appendChild(doc.createTextNode("32"));
            nodo2.appendChild(proveedor2);

            Element nombre2 = doc.createElement("nombre");
            nombre2.appendChild(doc.createTextNode("Entrepinares"));
            nodo2.appendChild(nombre2);

            Element producto2 = doc.createElement("producto");
            producto2.appendChild(doc.createTextNode("Queso tierno"));
            nodo2.appendChild(producto2);

            Element cantidad2 = doc.createElement("cantidad");
            cantidad2.appendChild(doc.createTextNode("50"));
            nodo2.appendChild(cantidad2);

            Element precio2 = doc.createElement("precio");
            precio2.appendChild(doc.createTextNode("220.67"));
            nodo2.appendChild(precio2);

            //definimos el nodo3
            Element nodo3 = doc.createElement("Pedido");
            raiz.appendChild(nodo3);

            Attr attr3 = doc.createAttribute("id");
            attr3.setValue("123");
            nodo3.setAttributeNode(attr3);

            //definimos los elementos del nodo3
            Element proveedor3 = doc.createElement("proveedor");
            proveedor3.appendChild(doc.createTextNode("50"));
            nodo3.appendChild(proveedor3);

            Element nombre3 = doc.createElement("nombre");
            nombre3.appendChild(doc.createTextNode("El Pozo"));
            nodo3.appendChild(nombre3);

            Element producto3 = doc.createElement("producto");
            producto3.appendChild(doc.createTextNode("Chorizo"));
            nodo3.appendChild(producto3);

            Element cantidad3 = doc.createElement("cantidad");
            cantidad3.appendChild(doc.createTextNode("33"));
            nodo3.appendChild(cantidad3);

            Element precio3 = doc.createElement("precio");
            precio3.appendChild(doc.createTextNode("92.7"));
            nodo3.appendChild(precio3);

            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            DOMSource source = new DOMSource(doc);

            StreamResult result = new StreamResult(file);

            transformer.transform(source, result);

        } catch (Exception e) {
            e.printStackTrace();
        }
        return file;
    }

    private static void modificarFichero(File file) {
        try {

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document doc = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/Pedidos/Pedido", doc, XPathConstants.NODESET));

            for (int i = 0; i < nodeList.getLength(); i++) {

                if (nodeList.item(i).getChildNodes().item(2).getTextContent().compareToIgnoreCase("Queso tierno") == 0) {
                    nodeList.item(i).getChildNodes().item(2).setTextContent("Queso semicurado");
                }

            }
            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            DOMSource source = new DOMSource(doc);
            StreamResult result = new StreamResult(new File("Pedidos.xml"));
            transformer.transform(source, result);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //cada vez que lo he ejecutado se ha copiado por lo que el archivo tiene ya varias copias hechas
    private static void copiarNodo(File archivoOrigen, File archivoDestino) {
        try {

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlOrigen = builder.parse(archivoOrigen);
            Document xmlDestino = builder.parse(archivoDestino);

            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/Pedidos/Pedido", xmlOrigen, XPathConstants.NODESET));

            for (int i = 0; i < nodeList.getLength(); i++) {
                if (nodeList.item(i).getChildNodes().item(2).getTextContent().compareToIgnoreCase("Queso semicurado") == 0) {
                    Node nodo = (Node) nodeList.item(i);
                    Node nodoCopiado = xmlDestino.importNode(nodo, true);
                    xmlDestino.getDocumentElement().appendChild(nodoCopiado);

                    TransformerFactory transformerFactory = TransformerFactory.newInstance();
                    Transformer transformer = transformerFactory.newTransformer();
                    DOMSource source = new DOMSource(xmlDestino);

                    StreamResult result = new StreamResult(archivoDestino);

                    transformer.transform(source, result);

                    break;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}
