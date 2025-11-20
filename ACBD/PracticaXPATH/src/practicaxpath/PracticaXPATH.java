package practicaxpath;

import java.io.File;
import java.util.ArrayList;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathFactory;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;


public class PracticaXPATH {

    public static void main(String[] args) {
        try {
            File file = new File("Empleados.xml");

            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlDocument = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            Node nodo = (Node) (xPath.evaluate("/Empleados/Empleado", xmlDocument, XPathConstants.NODE));
            NodeList nodeList = (NodeList) (xPath.evaluate("/Empleados/Empleado", xmlDocument, XPathConstants.NODESET));

            //empleado con id 4
            for (int i = 0; i < nodeList.getLength(); i++) {
                if (nodeList.item(i).getAttributes().item(0).getTextContent().equalsIgnoreCase("4")) {
                    System.out.printf("Empleado/a con ID 4: ");
                    System.out.println(nodeList.item(i).getChildNodes().item(3).getTextContent());
                }
            }
            
            //empleados mayores de 30
            ArrayList<String> mayores = new ArrayList<>();
            for (int i = 0; i < nodeList.getLength(); i++) {
                if (Integer.parseInt(nodeList.item(i).getChildNodes().item(1).getTextContent()) >= 30) {
                    mayores.add(nodeList.item(i).getChildNodes().item(3).getTextContent());
                }
            }
            System.out.printf("Empleado/as mayor/es de 30 annos: ");
            System.out.println(mayores);

            //empleadas mujeres
            ArrayList<String> mujeres = new ArrayList<>();
            for (int i = 0; i < nodeList.getLength(); i++) {
                if (nodeList.item(i).getChildNodes().item(5).getTextContent().equalsIgnoreCase("Mujer")) {
                    mujeres.add(nodeList.item(i).getChildNodes().item(3).getTextContent());
                }
            }
            System.out.printf("Empleada/s mujer/es: ");
            System.out.println(mujeres);
            
            //mostrar el nodo
            System.out.println("Nodo:");
            System.out.println(nodo.getTextContent());

        } catch (Exception ex) {
            ex.printStackTrace();
        }

    }

}
