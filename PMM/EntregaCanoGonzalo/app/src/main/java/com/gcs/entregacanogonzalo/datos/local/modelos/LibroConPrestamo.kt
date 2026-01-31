package com.gcs.entregacanogonzalo.datos.local.modelos

data class LibroConPrestamo(
    val isbn: String,
    val titulo: String,
    val autor: String,
    val personaId_FK: String?,
    val fechaPrestamo: String?
)
