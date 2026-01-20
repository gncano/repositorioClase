/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.gestion_inventario.servicios;

import com.gestion_inventario.modelo.Categoria;
import com.gestion_inventario.repositorios.CategoriaRepositorio;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author dam
 */
@Service
public class CategoriaServicio {

    private final CategoriaRepositorio categoriaRepositorio;

    @Autowired
    public CategoriaServicio(CategoriaRepositorio categoriaRepositorio) {
        this.categoriaRepositorio = categoriaRepositorio;
    }
    
    
    public List<Categoria> obtenerTodasLasCategorias() {
     return categoriaRepositorio.findAll();
    }
    
}
