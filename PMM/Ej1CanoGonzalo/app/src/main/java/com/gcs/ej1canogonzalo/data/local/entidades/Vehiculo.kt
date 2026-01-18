package com.gcs.ej1canogonzalo.data.local.entidades


data class Vehiculo (
    val matricula: String,
    val modelo: String,
    val observaciones: String,
    val estado: String,
    val mecanicoId: Int
)