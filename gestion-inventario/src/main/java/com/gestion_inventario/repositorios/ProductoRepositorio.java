package com.gestion_inventario.repositorios;

import com.gestion_inventario.modelo.Producto;
import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author dam
 */
public interface ProductoRepositorio extends JpaRepository<Producto, Long>{
    
}
