package com.gcs.ej1canogonzalo.data.local.entidades


data class Vehiculo (
    val DNI: String,
    val nombre_apellidos: String,
    val email: String,
    val matricula: String,
    val modelo: String,
    val fechaEntrega: String,
    val observaciones: String,
    var estado: String,
    val mecanicoId: Int
)