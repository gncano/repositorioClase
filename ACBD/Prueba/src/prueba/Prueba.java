package prueba;

import org.w3c.dom.*;
import org.xml.sax.*;
import org.xml.sax.helpers.DefaultHandler;

import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import javax.xml.xpath.*;
import java.io.*;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Prueba {

    // ---------- UTIL: guardar Document en archivo ----------
    private static void guardarDocumento(Document doc, File destino) throws Exception {
        TransformerFactory tf = TransformerFactory.newInstance();
        Transformer t = tf.newTransformer();
        t.setOutputProperty(OutputKeys.INDENT, "yes");
        t.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "2");
        DOMSource src = new DOMSource(doc);
        StreamResult res = new StreamResult(destino);
        t.transform(src, res);
    }

    // ---------- PARTE 1.1: corregir edad de Pablo (DOM) ----------
    private static void corregirEdadPablo(File empleadosFile) {
        try {
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document doc = b.parse(empleadosFile);
            doc.getDocumentElement().normalize();

            NodeList empleados = doc.getElementsByTagName("Empleado");
            boolean modificado = false;
            for (int i = 0; i < empleados.getLength(); i++) {
                Element emp = (Element) empleados.item(i);
                Element nombreElem = (Element) emp.getElementsByTagName("nombre").item(0);
                if (nombreElem != null && "Pablo".equalsIgnoreCase(nombreElem.getTextContent().trim())) {
                    Element edadElem = (Element) emp.getElementsByTagName("edad").item(0);
                    if (edadElem != null) {
                        edadElem.setTextContent("20"); // corregimos a 20
                        modificado = true;
                    }
                    break;
                }
            }
            if (modificado) {
                guardarDocumento(doc, empleadosFile);
                System.out.println("1) Corregida la edad de Pablo a 20 en " + empleadosFile.getName());
            } else {
                System.out.println("1) Pablo no encontrado para corregir.");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 2: XPath - roles de empleados con edad <= 25 ----------
    private static void mostrarRolesEdadMenorIgual25(File empleadosFile) {
        try {
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document doc = b.parse(empleadosFile);
            XPath xPath = XPathFactory.newInstance().newXPath();

            // XPath que devuelve NodeList con elementos <rol> de Empleado con edad <= 25
            String expr = "/Empleados/Empleado[edad <= 25]/rol";
            NodeList roles = (NodeList) xPath.evaluate(expr, doc, XPathConstants.NODESET);

            System.out.println("2) Roles de empleados con edad <= 25:");
            if (roles.getLength() == 0) {
                System.out.println("   (ninguno)");
            } else {
                for (int i = 0; i < roles.getLength(); i++) {
                    System.out.println("   - " + roles.item(i).getTextContent().trim());
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 3: Crear CopiaDeEmpleados.xml desde cero con tu empleado ----------
    private static void crearCopiaDesdeCero(File destino) {
        try {
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document doc = b.newDocument();

            Element root = doc.createElement("Empleados");
            doc.appendChild(root);

            // crear empleado (tus datos)
            Element emp = doc.createElement("Empleado");
            emp.setAttribute("id", "100"); // id de ejemplo

            Element edad = doc.createElement("edad");
            edad.setTextContent("28");
            emp.appendChild(edad);

            Element nombre = doc.createElement("nombre");
            nombre.setTextContent("TuNombre");
            emp.appendChild(nombre);

            Element genero = doc.createElement("genero");
            genero.setTextContent("Mujer"); // o Hombre
            emp.appendChild(genero);

            Element rol = doc.createElement("rol");
            rol.setTextContent("Estudiante");
            emp.appendChild(rol);

            root.appendChild(emp);

            guardarDocumento(doc, destino);
            System.out.println("3) Creado " + destino.getName() + " con un empleado inicial (tus datos).");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 4: Copiar nodo Tomás desde Empleados.xml a CopiaDeEmpleados.xml ----------
    private static void copiarEmpleadoPorNombre(File origen, File destino, String nombreBuscar) {
        try {
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document docOrigen = b.parse(origen);
            docOrigen.getDocumentElement().normalize();

            Document docDestino = b.parse(destino);
            docDestino.getDocumentElement().normalize();

            NodeList empleados = docOrigen.getElementsByTagName("Empleado");
            Node encontrado = null;
            for (int i = 0; i < empleados.getLength(); i++) {
                Element e = (Element) empleados.item(i);
                Node nom = e.getElementsByTagName("nombre").item(0);
                if (nom != null && nombreBuscar.equalsIgnoreCase(nom.getTextContent().trim())) {
                    encontrado = e;
                    break;
                }
            }

            if (encontrado == null) {
                System.out.println("4) No se encontró empleado con nombre " + nombreBuscar);
                return;
            }

            Node copia = docDestino.importNode(encontrado, true);
            // opcional: si quieres evitar duplicados por id, modificar id
            if (copia.getAttributes() != null && copia.getAttributes().getNamedItem("id") != null) {
                String idAnt = copia.getAttributes().getNamedItem("id").getTextContent();
                copia.getAttributes().getNamedItem("id").setTextContent(idAnt + "_copia");
            }

            docDestino.getDocumentElement().appendChild(copia);
            guardarDocumento(docDestino, destino);
            System.out.println("4) Copiado empleado '" + nombreBuscar + "' a " + destino.getName());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 5: Eliminar último nodo en copia y añadir atributo al primero ----------
    private static void eliminarUltimoYAgregarAtributo(File copia) {
        try {
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document doc = b.parse(copia);
            doc.getDocumentElement().normalize();

            NodeList empleados = doc.getElementsByTagName("Empleado");
            int len = empleados.getLength();
            if (len > 0) {
                if (len > 1) {
                    Node ultimo = empleados.item(len - 1);
                    ultimo.getParentNode().removeChild(ultimo);
                    System.out.println("5) Eliminado último empleado de " + copia.getName());
                } else {
                    System.out.println("5) Solo hay 1 empleado, no se elimina ninguno (según enunciado habría sido el copiado).");
                }

                // volver a obtener (o usar item(0) directamente)
                Element primero = (Element) doc.getElementsByTagName("Empleado").item(0);
                if (primero != null) {
                    primero.setAttribute("activo", "true");
                    System.out.println("5) Añadido atributo activo=\"true\" al primer empleado en " + copia.getName());
                }
            } else {
                System.out.println("5) Archivo copia sin empleados.");
            }
            guardarDocumento(doc, copia);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 6: SAX parser que muestra id, nombre y rol ----------
    private static class EmpleadoSAXHandler extends DefaultHandler {
        private StringBuilder current = new StringBuilder();
        private String id;
        private String nombre;
        private String rol;
        private boolean insideEmpleado = false;

        @Override
        public void startElement(String uri, String localName, String qName, Attributes attributes) {
            current.setLength(0);
            if ("Empleado".equalsIgnoreCase(qName)) {
                insideEmpleado = true;
                id = attributes.getValue("id");
                nombre = null;
                rol = null;
            }
        }

        @Override
        public void characters(char[] ch, int start, int length) {
            current.append(ch, start, length);
        }

        @Override
        public void endElement(String uri, String localName, String qName) {
            if (!insideEmpleado) return;
            switch (qName.toLowerCase()) {
                case "nombre":
                    nombre = current.toString().trim();
                    break;
                case "rol":
                    rol = current.toString().trim();
                    break;
                case "empleado":
                    // fin del empleado
                    System.out.println("6) Empleado id=" + id + " - nombre=" + nombre + " - rol=" + rol);
                    insideEmpleado = false;
                    break;
            }
        }
    }

    private static void parsearConSAX(File origen) {
        try {
            SAXParserFactory sf = SAXParserFactory.newInstance();
            SAXParser sp = sf.newSAXParser();
            EmpleadoSAXHandler handler = new EmpleadoSAXHandler();
            sp.parse(origen, handler);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 7: Crear carpeta datos y escribir empleados_log.txt ----------
    private static void escribirLogEmpleados(File empleadosFile, File carpetaDatos) {
        try {
            if (!carpetaDatos.exists()) carpetaDatos.mkdirs();
            File log = new File(carpetaDatos, "empleados_log.txt");

            // leer con DOM para obtener nombre y rol (o usar XPath)
            DocumentBuilderFactory f = DocumentBuilderFactory.newInstance();
            DocumentBuilder b = f.newDocumentBuilder();
            Document doc = b.parse(empleadosFile);
            NodeList empleados = doc.getElementsByTagName("Empleado");

            try (BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(log), StandardCharsets.UTF_8))) {
                for (int i = 0; i < empleados.getLength(); i++) {
                    Element e = (Element) empleados.item(i);
                    String nombre = e.getElementsByTagName("nombre").item(0).getTextContent().trim();
                    String rol = e.getElementsByTagName("rol").item(0).getTextContent().trim();
                    bw.write("Empleado: " + nombre + " – Rol: " + rol);
                    bw.newLine();
                }
            }
            System.out.println("7) Generado " + log.getPath());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 8: Leer el log con FileInputStream byte a byte ----------
    private static void leerLogBytes(File carpetaDatos) {
        File log = new File(carpetaDatos, "empleados_log.txt");
        if (!log.exists()) {
            System.out.println("8) Log no existe: " + log.getPath());
            return;
        }
        System.out.println("8) Leyendo " + log.getPath() + " byte a byte:");
        try (FileInputStream fis = new FileInputStream(log)) {
            int b;
            while ((b = fis.read()) != -1) {
                System.out.print((char) b);
            }
            System.out.println("\n--- fin lectura ---");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    // ---------- PARTE 9: RandomAccessFile demo ----------
    private static void randomAccessDemo(File registro) {
        try (RandomAccessFile raf = new RandomAccessFile(registro, "rw")) {
            // vamos a escribir 3 nombres en registros de longitud fija 32 bytes (ASCII/UTF-8 truncado/padded)
            int recordSize = 32;
            String[] nombres = {"Ana", "Luis", "María"};
            // limpiar/truncar el fichero
            raf.setLength(0);

            // escribir 3 registros
            for (int i = 0; i < 3; i++) {
                byte[] data = nombres[i].getBytes(StandardCharsets.UTF_8);
                byte[] buf = new byte[recordSize];
                System.arraycopy(data, 0, buf, 0, Math.min(data.length, recordSize));
                raf.write(buf);
            }
            System.out.println("9) Escrito registro con 3 nombres.");

            // posicionar en el segundo registro y reemplazarlo
            raf.seek(recordSize * 1); // segundo registro (índice 1)
            String nuevo = "Roberto";
            byte[] data = nuevo.getBytes(StandardCharsets.UTF_8);
            byte[] buf = new byte[recordSize];
            System.arraycopy(data, 0, buf, 0, Math.min(data.length, recordSize));
            raf.write(buf);
            System.out.println("9) Reemplazado segundo nombre por " + nuevo);

            // leer todos los registros
            raf.seek(0);
            System.out.println("9) Contenido de " + registro.getName() + ":");
            for (int i = 0; i < 3; i++) {
                byte[] rec = new byte[recordSize];
                raf.readFully(rec);
                String s = new String(rec, StandardCharsets.UTF_8).trim();
                System.out.println("   - " + s);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    // ---------- MAIN: ejecutar todas las partes en orden ----------
    public static void main(String[] args) {
        File origen = new File("Empleados.xml"); // debe existir con el contenido del enunciado
        File copia = new File("CopiaDeEmpleados.xml");
        File datosDir = new File("datos");
        File registro = new File("registro.dat");

        // 1) Corregir Pablo
        corregirEdadPablo(origen);

        // 2) XPath roles <= 25
        mostrarRolesEdadMenorIgual25(origen);

        // 3) Crear copia desde cero (tu empleado)
        crearCopiaDesdeCero(copia);

        // 4) Copiar Tomás desde origen a copia
        copiarEmpleadoPorNombre(origen, copia, "Tomás");

        // 5) Eliminar último nodo (copiado) y añadir atributo al primero
        eliminarUltimoYAgregarAtributo(copia);

        // 6) SAX parse del origen
        parsearConSAX(origen);

        // 7) Escribir log en datos/empleados_log.txt
        escribirLogEmpleados(origen, datosDir);

        // 8) Leer log byte a byte
        leerLogBytes(datosDir);

        // 9) RandomAccessFile demo
        randomAccessDemo(registro);

        System.out.println("\n--- FIN de la práctica integrada ---");
    }
}
