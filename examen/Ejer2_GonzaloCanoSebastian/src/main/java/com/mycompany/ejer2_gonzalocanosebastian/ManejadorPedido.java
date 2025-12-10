package com.mycompany.ejer2_gonzalocanosebastian;

import java.util.ArrayList;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author dam
 */
public class ManejadorPedido extends DefaultHandler {

    ArrayList<Pedido> pedidos = new ArrayList<>();
    private Pedido pedido;
    private StringBuilder valorActual;

    public ManejadorPedido() {
        this.valorActual = new StringBuilder();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        valorActual.setLength(0);
        
        
        if (qName.equalsIgnoreCase("Pedido")) {
            pedido = new Pedido();
            int id = Integer.parseInt(attributes.getValue("id"));
            pedido.setId(id);
        }
    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        valorActual.append(ch, start, length);
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        switch (qName) {
            case "nombre":
                pedido.setNombre(valorActual.toString().trim());
                break;
            case "precio":
                pedido.setPrecio(Float.parseFloat(valorActual.toString().trim()));
                break;
            case "proveedor":
                pedido.setProveedor(valorActual.toString().trim());
                break;
            case "cantidad":
                pedido.setCantidad(Integer.parseInt(valorActual.toString().trim()));
                break;
            case "producto":
                pedido.setProducto(valorActual.toString().trim());
                break;
            case "Pedido":
                pedidos.add(pedido);
                break;
        }
    }

    public ArrayList<Pedido> getPedidos() {
        return pedidos;
    }
}
