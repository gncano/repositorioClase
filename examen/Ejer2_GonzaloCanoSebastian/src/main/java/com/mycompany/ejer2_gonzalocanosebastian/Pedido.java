package com.mycompany.ejer2_gonzalocanosebastian;

/**
 *
 * @author dam
 */
public class Pedido {

    private int id;
    private String proveedor;
    private String nombre;
    private String producto;
    private int cantidad;
    private float precio;

    public Pedido() {
    }

    public int getId() {
        return id;
    }

    public String getProveedor() {
        return proveedor;
    }

    public String getNombre() {
        return nombre;
    }

    public String getProducto() {
        return producto;
    }

    public int getCantidad() {
        return cantidad;
    }

    public float getPrecio() {
        return precio;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setProveedor(String proveedor) {
        this.proveedor = proveedor;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setProducto(String producto) {
        this.producto = producto;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    @Override
    public String toString() {
        return "id Pedido=" + id + "\n"
                + "Nombre=" + nombre + "\n"
                + "Proveedor=" + proveedor + "\n"
                + "Producto=" + producto + "\n"
                + "Cantidad=" + cantidad + "\n"
                + "Precio=" + precio + "\n"
                + "**********************\n";
    }
}
