package com.gcs.ej2canogonzalo.data.local

import com.gcs.ej2canogonzalo.data.local.entidades.Producto

object DatosProductos {
    val productos = mutableListOf(
        Producto(
            "CAM01",
            "Casual",
            "Camiseta básica",
            12.99f,
            "blanco",
            18
        ),
        Producto(
            "JKT01",
            "Formal",
            "Chaqueta elegante",
            59.99f,
            "negro",
            7
        ),
        Producto(
            "RUN01",
            "Deportivo",
            "Pantalón de running",
            29.50f,
            "gris",
            14
        ),
        Producto(
            "BAG01",
            "Accesorios",
            "Bolso bandolera",
            24.99f,
            "marrón",
            10
        ),
        Producto(
            "SUD01",
            "Novedades",
            "Sudadera oversize",
            39.99f,
            "verde",
            9
        ),
        Producto(
            "ABR01",
            "Novedades",
            "Abrigo de piel",
            79.99f,
            "marrón",
            20
        )
    )

}