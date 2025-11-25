package practicadom;

import java.io.File;
import java.util.ArrayList;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
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
public class PracticaDOM {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        File file = new File("Empleados.xml");

        //cambia un nodo
        modificarXml(file);
        //busca a los de menos de 25 y los muestra por pantalla
        buscar(file);
        //crea un xml introduciendo los nodos por codigo
        File copia = nuevoDocumento();
        //copia un nodo en otro archivo
        copiarNodo(file, copia);
        //elimina un nodo y un atributo
        eliminarNodoyAtributo(copia);
    }

    private static void modificarXml(File file) {
        try {

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document doc = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/Empleados/Empleado", doc, XPathConstants.NODESET));

            for (int i = 0; i < nodeList.getLength(); i++) {

                if (nodeList.item(i).getChildNodes().item(3).getTextContent().compareToIgnoreCase("Pablo") == 0) {
                    nodeList.item(i).getChildNodes().item(1).setTextContent("20");
                }

            }
            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            DOMSource source = new DOMSource(doc);
            StreamResult result = new StreamResult(new File("Empleados.xml"));
            transformer.transform(source, result);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static File nuevoDocumento() {
        File copia = new File("CopiaDeEmpleados.xml");
        try {

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document doc = builder.newDocument();
            XPath xPath = XPathFactory.newInstance().newXPath();

            // definimos el elemento raíz del documento
            Element raiz = doc.createElement("Empleado");
            doc.appendChild(raiz);

            // definimos el nodo que contendrá los elementos
            Element nodo = doc.createElement("Empleados");
            raiz.appendChild(nodo);

            // atributo para el nodo 
            Attr attr = doc.createAttribute("id");
            attr.setValue("1");
            nodo.setAttributeNode(attr);

            // definimos cada uno de los elementos y le asignamos un valor
            Element edad = doc.createElement("edad");
            edad.appendChild(doc.createTextNode("24"));
            nodo.appendChild(edad);

            Element nombre = doc.createElement("nombre");
            nombre.appendChild(doc.createTextNode("Gonzalo"));
            nodo.appendChild(nombre);

            Element genero = doc.createElement("genero");
            genero.appendChild(doc.createTextNode("Hombre"));
            nodo.appendChild(genero);

            Element rol = doc.createElement("rol");
            rol.appendChild(doc.createTextNode("Developer"));
            nodo.appendChild(rol);

            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            DOMSource source = new DOMSource(doc);

            StreamResult result = new StreamResult(copia);

            transformer.transform(source, result);

        } catch (Exception e) {

            e.printStackTrace();
        }
        return copia;
    }

    private static void buscar(File file) {
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlDocument = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/Empleados/Empleado", xmlDocument, XPathConstants.NODESET));

            ArrayList<String> roles = new ArrayList<>();

            for (int i = 0; i < nodeList.getLength(); i++) {
                if (Integer.parseInt(nodeList.item(i).getChildNodes().item(1).getTextContent()) <= 25) {
                    roles.add(nodeList.item(i).getChildNodes().item(7).getTextContent());
                }
            }
            System.out.printf("roles de menos de 25 annos: ");
            System.out.println(roles);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void copiarNodo(File archivoOrigen, File archivoDestino) {
        try {
            String nombreEmpleado = "Tomás";

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlOrigen = builder.parse(archivoOrigen);
            Document xmlDestino = builder.parse(archivoDestino);

            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/Empleados/Empleado", xmlOrigen, XPathConstants.NODESET));

            for (int i = 0; i < nodeList.getLength(); i++) {
                if (nodeList.item(i).getChildNodes().item(3).getTextContent().equalsIgnoreCase(nombreEmpleado)) {
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

    private static void eliminarNodoyAtributo(File copia) {
        try {
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = factory.newDocumentBuilder();
            Document doc = builder.parse(copia);

            NodeList empleados = doc.getElementsByTagName("Empleado");

            if (empleados.getLength() > 1) {
                // Eliminar el último nodo 
                Node ultimoEmpleado = empleados.item(empleados.getLength() - 1);
                ultimoEmpleado.getParentNode().removeChild(ultimoEmpleado);
            }

            if (empleados.getLength() > 0) {
                // Añadir atributo al primer nodo que queda
                Element primerEmpleado = (Element) empleados.item(0);
                primerEmpleado.setAttribute("activo", "true");
            }

            // Guardar los cambios en el archivo
            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            transformer.setOutputProperty(OutputKeys.INDENT, "yes");
            transformer.transform(new DOMSource(doc), new StreamResult(copia));

            System.out.println("Nodo eliminado y atributo añadido correctamente.");

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
