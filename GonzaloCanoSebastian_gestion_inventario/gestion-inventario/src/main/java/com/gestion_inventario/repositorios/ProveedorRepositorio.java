/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package com.gestion_inventario.repositorios;

import com.gestion_inventario.modelo.Proveedor;
import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author dam
 */
public interface ProveedorRepositorio  extends JpaRepository<Proveedor, Long>{
    Proveedor findByNombre(String nombre);
}
