package com.gcs.ej1canogonzalo.data.local.entidades

import android.R

data class Vehiculo (
    val dni: String,
    val nombre_apellidos: String,
    val email: String,
    val matricula: String,
    val modelo: String,
    val fecha_entrega: String,
    val observaciones: String,
    val estado: R.bool
)