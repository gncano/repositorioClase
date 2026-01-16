package com.gcs.ej1canogonzalo.data.repositorio

import com.gcs.ej1canogonzalo.data.local.DatosUsuarios
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario

class RepositorioUsuario {

    fun validarUsuario(login: String, password: String): Usuario? {
        return DatosUsuarios.usuarios.find { usuario ->
            usuario.login == login && usuario.password == password
        }
    }
}