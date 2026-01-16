package com.gcs.ej1canogonzalo.data.local

import com.gcs.ej1canogonzalo.data.local.entidades.Usuario

object DatosUsuarios {
    val usuarios = listOf(
        Usuario(
            login = "mecanico",
            password = "1234",
            perfil = 0
        ),
        Usuario(
            login = "recepcion",
            password = "1234",
            perfil = 1
        )
    )
}