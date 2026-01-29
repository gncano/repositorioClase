package com.gestion_inventario.modelo;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.HashSet;
import java.util.Set;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
public class Proveedor {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String nombre;
    private int telefono;
    private String email;

    @ManyToMany(mappedBy = "proveedores", fetch = FetchType.EAGER)
    private Set<Producto> productos = new HashSet<>();
}
