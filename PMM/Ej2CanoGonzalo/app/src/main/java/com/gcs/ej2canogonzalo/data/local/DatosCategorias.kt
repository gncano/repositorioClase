package com.gcs.ej2canogonzalo.data.local

import com.gcs.ej2canogonzalo.data.local.entidades.Categoria

object DatosCategorias {

    val categorias = listOf(
        Categoria(
            "Novedades",
            "Últimas tendencias y lanzamientos"
        ),
        Categoria(
            "Casual",
            "Ropa cómoda para el día a día"
        ),
        Categoria(
            "Deportivo",
            "Prendas para entrenamiento y actividad física"
        ),
        Categoria(
            "Formal",
            "Ropa elegante para eventos y trabajo"
        ),
        Categoria(
            "Accesorios",
            "Complementos para completar tu look"
        )
    )
}