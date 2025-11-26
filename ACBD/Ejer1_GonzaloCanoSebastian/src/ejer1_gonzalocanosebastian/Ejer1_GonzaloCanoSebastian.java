/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package ejer1_gonzalocanosebastian;

import java.io.File;
import java.util.ArrayList;
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
        masDe500cal(file);
        menosDe6(file);
        
        //modificar(file);

    }

    private static File crearFichero() {
        File file = new File("MenuCompleto.xml");
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document doc = builder.newDocument();
         
            XPath xPath = XPathFactory.newInstance().newXPath();

            // definimos el elemento raíz del documento
            Element raiz = doc.createElement("menu");
            doc.appendChild(raiz);

            // definimos el nodo que contendrá los elementos
            Element nodo = doc.createElement("comida");
            raiz.appendChild(nodo);

            // definimos cada uno de los elementos y le asignamos un valor
            Element nombre = doc.createElement("nombre");
            nombre.appendChild(doc.createTextNode("Tallarines con verduras y salsa de soja"));
            nodo.appendChild(nombre);

            Element precio = doc.createElement("precio");
            precio.appendChild(doc.createTextNode("6.95"));
            nodo.appendChild(precio);

            Element descripcion = doc.createElement("descripcion");
            descripcion.appendChild(doc.createTextNode("Tallarines con cebolla, pimiento rojo y calabacín con salsa de soja"));
            nodo.appendChild(descripcion);

            Element calorias = doc.createElement("calorias");
            calorias.appendChild(doc.createTextNode("650"));
            nodo.appendChild(calorias);

            //definimos el nodo2
            Element nodo2 = doc.createElement("comida");
            raiz.appendChild(nodo2);

            //definimos los elementos del nodo2
            Element nombre2 = doc.createElement("nombre");
            nombre2.appendChild(doc.createTextNode("Patatas guisadas con chorizo"));
            nodo2.appendChild(nombre2);

            Element precio2 = doc.createElement("precio");
            precio2.appendChild(doc.createTextNode("7.95"));
            nodo2.appendChild(precio2);

            Element descripcion2 = doc.createElement("descripcion");
            descripcion2.appendChild(doc.createTextNode("Patatas guisadas con puerro y chorizo"));
            nodo2.appendChild(descripcion2);

            Element calorias2 = doc.createElement("calorias");
            calorias2.appendChild(doc.createTextNode("900"));
            nodo2.appendChild(calorias2);

            //definimos el nodo3
            Element nodo3 = doc.createElement("comida");
            raiz.appendChild(nodo3);

            //definimos los elementos del nodo4
            Element nombre3 = doc.createElement("nombre");
            nombre3.appendChild(doc.createTextNode("Huevos fritos con patatas"));
            nodo3.appendChild(nombre3);

            Element precio3 = doc.createElement("precio");
            precio3.appendChild(doc.createTextNode("5.95"));
            nodo3.appendChild(precio3);

            Element descripcion3 = doc.createElement("descripcion");
            descripcion3.appendChild(doc.createTextNode("Dos huevos fritos con una ración de patatas fritas"));
            nodo3.appendChild(descripcion3);

            Element calorias3 = doc.createElement("calorias");
            calorias3.appendChild(doc.createTextNode("115"));
            nodo3.appendChild(calorias3);

            //definimos el nodo4
            Element nodo4 = doc.createElement("comida");
            raiz.appendChild(nodo4);

            //definimos los elementos del nodo4
            Element nombre4 = doc.createElement("nombre");
            nombre4.appendChild(doc.createTextNode("Sopa castellana"));
            nodo4.appendChild(nombre4);

            Element precio4 = doc.createElement("precio");
            precio4.appendChild(doc.createTextNode("6.85"));
            nodo4.appendChild(precio4);

            Element descripcion4 = doc.createElement("descripcion");
            descripcion4.appendChild(doc.createTextNode("Sopa a base de pan, huevo, pimentón y ajo"));
            nodo4.appendChild(descripcion4);

            Element calorias4 = doc.createElement("calorias");
            calorias4.appendChild(doc.createTextNode("105"));
            nodo4.appendChild(calorias4);

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

    private static void masDe500cal(File file) {
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlDocument = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/menu/comida", xmlDocument, XPathConstants.NODESET));

            ArrayList<String> masDe500 = new ArrayList<>();

            for (int i = 0; i < nodeList.getLength(); i++) {
                if (Integer.parseInt(nodeList.item(i).getChildNodes().item(3).getTextContent()) >= 500) {
                    masDe500.add(nodeList.item(i).getChildNodes().item(0).getTextContent());
                }
            }
            System.out.printf("Comidas con mas de 500 calorias:  ");
            System.out.println(masDe500);

        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    private static void menosDe6(File file) {
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlDocument = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();

            NodeList nodeList = (NodeList) (xPath.evaluate("/menu/comida", xmlDocument, XPathConstants.NODESET));

            ArrayList<String> lista = new ArrayList<>();

            for (int i = 0; i < nodeList.getLength(); i++) {
                if (Float.parseFloat(nodeList.item(i).getChildNodes().item(1).getTextContent()) < 6) {
                    lista.add(nodeList.item(i).getChildNodes().item(2).getTextContent());
                }
            }
            System.out.printf("Comidas de menos de 6 euros:  ");
            System.out.println(lista);

        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    private static void modificar(File file) {
        try {
            DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = builderFactory.newDocumentBuilder();
            Document xmlDocument = builder.parse(file);
            XPath xPath = XPathFactory.newInstance().newXPath();
            Document doc = builder.newDocument();

            NodeList nodeList = (NodeList) (xPath.evaluate("/menu/comida", xmlDocument, XPathConstants.NODESET));

            for (int i = 0; i < nodeList.getLength(); i++) {
                Element e= (Element) nodeList.item(i);
                
                
                
                Element servicio = doc.createElement("servicio");
                servicio.appendChild(doc.createTextNode("En local, en terraza y para llevar"));
                e.appendChild(servicio);
            }

            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            DOMSource source = new DOMSource(doc);

            StreamResult result = new StreamResult(file);

            transformer.transform(source, result);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

}
