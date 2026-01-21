package com.gcs.ej2canogonzalo.data.local.entidades

data class Producto(
    val codigo: String,
    val categoria: String,
    val denominacion: String,
    var precio: Float,
    val color: String,
    var existencias: Int
)
