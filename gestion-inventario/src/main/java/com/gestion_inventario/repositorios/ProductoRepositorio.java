package com.gestion_inventario.repositorios;

import com.gestion_inventario.modelo.Producto;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

/**
 *
 * @author dam
 */
public interface ProductoRepositorio extends JpaRepository<Producto, Long>{
    List<Producto> findByCategoriaNombre(String nombre);
}
