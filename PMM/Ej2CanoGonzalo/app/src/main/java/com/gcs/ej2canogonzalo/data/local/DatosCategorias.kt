package com.gcs.ej2canogonzalo.data.local

import com.gcs.ej2canogonzalo.data.local.entidades.Categoria

object DatosCategorias {

    val categorias = listOf(
        Categoria(
            codigo = "Tops",
            denominacion = "Parte superior"
        ),
        Categoria(
            codigo = "Conjuntos",
            denominacion = "Parte superior e inferior"
        ),
        Categoria(
            codigo = "Bottoms",
            denominacion = "Parte inferior"
        ),
        Categoria(
            codigo = "Verano",
            denominacion = "Ropa de verano"
        ),
        Categoria(
            codigo = "Invierno",
            denominacion = "Ropa de invierno"
        )
    )
}