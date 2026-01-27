package com.gestion_inventario.servicios;

import com.gestion_inventario.modelo.Proveedor;
import com.gestion_inventario.repositorios.ProveedorRepositorio;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProveedorServicio {

    private final ProveedorRepositorio proveedorRepositorio;

    @Autowired
    public ProveedorServicio(ProveedorRepositorio proveedorRepositorio) {
        this.proveedorRepositorio = proveedorRepositorio;
    }

    public List<Proveedor> obtenerTodosLosProveedores() {
        return proveedorRepositorio.findAll();
    }

    public Proveedor obtenerProveedorPorNombre(String nombreProveedor) {
        return proveedorRepositorio.findByNombre(nombreProveedor);
    }
}
