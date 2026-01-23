package com.gestion_inventario.servicios;

import com.gestion_inventario.modelo.Producto;
import com.gestion_inventario.repositorios.ProductoRepositorio;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author dam
 */
@Service
public class ProductoServicio {


    private final ProductoRepositorio productoRepositorio;

    @Autowired
    public ProductoServicio(ProductoRepositorio productoRepositorio) {
        this.productoRepositorio = productoRepositorio;
    }

    public List<Producto> obtenerTodosLosProductos() {
        return productoRepositorio.findAll();
    }

    public List<Producto> obtenerPerifericos() {
        return productoRepositorio.findByCategoriaNombre("Perifericos");
    }
    public List<Producto> obtenerMonitoresAudio() {
        return productoRepositorio.findByCategoriaNombre("Monitores y Audio");
    }
    public List<Producto> obtenerAlmacenamiento() {
        return productoRepositorio.findByCategoriaNombre("Almacenamiento");
    }

    public Producto obtenerProductoPorId(Long idProducto) {
        return productoRepositorio.findById(idProducto).orElse(null);
    }
}
