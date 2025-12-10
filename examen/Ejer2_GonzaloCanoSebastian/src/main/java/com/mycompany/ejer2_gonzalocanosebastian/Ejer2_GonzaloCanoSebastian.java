package com.mycompany.ejer2_gonzalocanosebastian;

import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/**
 *
 * @author dam
 */
public class Ejer2_GonzaloCanoSebastian {

    public static void main(String[] args) {
        try {

            // Crear el parser SAX
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            // Crear el manejador y procesar el XML
            ManejadorPedido manejador = new ManejadorPedido();

            saxParser.parse("Pedidos.xml", manejador);

            // Mostrar los datos leídos
            System.out.println("Datos del pedido leidos del XML:");
            System.out.println(manejador.getPedidos());

            guardarProveedor32(manejador.getPedidos());
            generarJSON(manejador.getPedidos());

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void guardarProveedor32(ArrayList<Pedido> pedidos) {
        File archivo = new File("PedidoFinal.txt");

        try (BufferedWriter bw = new BufferedWriter(new FileWriter(archivo))) {
            for (Pedido pedido : pedidos) {
                if (pedido.getProveedor().equalsIgnoreCase("32")) {
                    String linea = "Id Pedido: " + pedido.getId() + " \nProducto: " + pedido.getProducto() + " \nPrecio: " + pedido.getPrecio() + "\n--------------------------------------";
                    bw.write(linea);
                    bw.newLine();
                }
            }
            System.out.println("Archivo 'PedidoFinal.txt' creado correctamente.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void generarJSON(ArrayList<Pedido> pedidos) {
        try {
            ObjectMapper objectMapper = new ObjectMapper();
            objectMapper.writeValue(new File("PedidoFinal.json"), pedidos);

            System.out.println("Archivo 'PedidoFinal.json' creado con exito");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
