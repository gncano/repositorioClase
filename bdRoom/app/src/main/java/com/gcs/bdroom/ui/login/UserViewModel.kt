package com.gcs.bdroommvvm.ui.login

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.gcs.bdroommvvm.datos.local.entities.Usuario
import com.gcs.bdroommvvm.datos.repository.UserRepository
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch

class UserViewModel(private val repository: UserRepository) : ViewModel() {

    // Canal para mensajes (Toasts)
    private val _message = MutableLiveData<String>()
    val message: LiveData<String> get() = _message

    // Canal para la navegación
    private val _navigateToProfile = MutableLiveData<String?>()
    val navigateToProfile: LiveData<String?> get() = _navigateToProfile

    fun registrar(user: String, pass: String) {
        if (user.isEmpty() || pass.isEmpty()) {
            _message.value = "Rellena todos los campos"
            return
        }

        viewModelScope.launch(Dispatchers.IO) {
            val exists = repository.checkUserExists(user)
            if (!exists) {
                repository.register(Usuario(login = user, password = pass))
                _message.postValue("Usuario $user registrado con éxito")
            } else {
                _message.postValue("El usuario ya existe")
            }
        }
    }

    fun login(user: String, pass: String) {
        viewModelScope.launch(Dispatchers.IO) {
            val usuarioEncontrado = repository.login(user, pass)
            if (usuarioEncontrado != null) {
                _navigateToProfile.postValue(usuarioEncontrado.login)
            } else {
                _message.postValue("Credenciales incorrectas")
            }
        }
    }

    // Limpiar el estado de navegación después de usarlo
    fun onNavigationDone() {
        _navigateToProfile.value = null
    }
}