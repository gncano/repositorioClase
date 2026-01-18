package com.gcs.ej1canogonzalo.data.local

import com.gcs.ej1canogonzalo.data.local.entidades.Usuario

object DatosUsuarios {
    val usuarios = listOf(
        Usuario(
            id = 0,
            login = "mecanico",
            password = "1234",
            perfil = 0
        ),
        Usuario(
            id = 1,
            login = "recepcion",
            password = "1234",
            perfil = 1
        ),
        Usuario(
            id = 2,
            login = "cano",
            password = "1234",
            perfil = 0
        )
    )
}