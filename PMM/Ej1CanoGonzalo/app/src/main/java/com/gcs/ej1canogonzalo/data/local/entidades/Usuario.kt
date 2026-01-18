package com.gcs.ej1canogonzalo.data.local.entidades

import java.io.Serializable

data class Usuario(
    val id: Int = 0,
    val login: String,
    val password: String,
    val perfil: Int
) : Serializable