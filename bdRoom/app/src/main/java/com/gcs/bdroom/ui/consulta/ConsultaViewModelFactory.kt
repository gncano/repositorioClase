package com.gcs.bdroommvvm.ui.consulta

import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import com.gcs.bdroommvvm.datos.local.AlumnoDAO
import com.gcs.bdroommvvm.datos.local.CursoDAO
import com.gcs.bdroommvvm.datos.local.UsuarioDao
import com.gcs.bdroommvvm.datos.repository.UserRepository


class ConsultaViewModelFactory(
    private val userDao: UsuarioDao,
    private val alumnoDao: AlumnoDAO,
    private val cursoDao: CursoDAO
) : ViewModelProvider.Factory {
    override fun <T : ViewModel> create(modelClass: Class<T>): T {
        if (modelClass.isAssignableFrom(ConsultaViewModel::class.java)) {
            // 1. Creamos el repositorio usando el DAO
            val repository = UserRepository(userDao, alumnoDao, cursoDao)
            // 2. Pasamos el repositorio al ViewModel
            @Suppress("UNCHECKED_CAST")
            return ConsultaViewModel(repository) as T
        }
        throw IllegalArgumentException("Unknown ViewModel class")
    }
}