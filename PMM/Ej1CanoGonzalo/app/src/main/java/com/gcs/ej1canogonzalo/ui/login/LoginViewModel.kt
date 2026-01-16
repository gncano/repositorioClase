package com.gcs.ej1canogonzalo.ui.login

import androidx.lifecycle.ViewModel
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.data.repositorio.RepositorioUsuario

class LoginViewModel : ViewModel() {
    private val repositorioUsuario = RepositorioUsuario()

    fun validarLogin(login: String, password: String): Usuario? {
        if (login.isBlank() || password.isBlank()) {
            return null
        }

        return repositorioUsuario.validarUsuario(login, password)
    }
}