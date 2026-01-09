package com.gcs.bdroommvvm.ui.consulta

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.asLiveData
import androidx.lifecycle.liveData
import androidx.lifecycle.viewModelScope
import com.gcs.bdroommvvm.datos.local.AlumnoConCurso
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.datos.repository.UserRepository

import kotlinx.coroutines.launch

class ConsultaViewModel(private val repository: UserRepository) : ViewModel() {
    // Convertimos el Flow a LiveData para la UI
    val allAlumnos: LiveData<List<Alumno>> = repository.allAlumno.asLiveData()
 val operacionExitosa = MutableLiveData<Long>()

    fun insertAlumno(alumno: Alumno) {
        if (alumno.dni.isEmpty() || alumno.nombre.isEmpty() || alumno.cursoIdRef==null) {

            operacionExitosa.postValue(-2 )
            return
        }
        viewModelScope.launch {
            try {
                val existe=repository.existeCurso(alumno.cursoIdRef)
                if (existe) {
                    val id = repository.registerAlumno(alumno)
                    operacionExitosa.postValue(id)
                }
                else{
                    operacionExitosa.postValue(-7L)
                }
            } catch (e: Exception) {
                operacionExitosa.postValue(-1L)
            }
        }

    }
    fun updateAlumno(alumno: Alumno) {
        if (alumno.nombre.isEmpty() || alumno.cursoIdRef==null) {
           operacionExitosa.postValue(-2L)
            return
        }
        viewModelScope.launch {
            try {
                val existe=repository.existeCurso(alumno.cursoIdRef)
                if (existe) {
                    repository.updateAlumno(alumno)
                    operacionExitosa.postValue(1L)
                }
                else{
                    operacionExitosa.postValue(-7L)
                }

            } catch (e: Exception) {
                operacionExitosa.postValue(-1L)
            }
        }

    }
    fun eliminarAlumno(alumno: Alumno) {

        viewModelScope.launch {
            try {
                repository.eliminarAlumno(alumno.dni)
                operacionExitosa.postValue(4L)
            } catch (e: Exception) {
                operacionExitosa.postValue(-1L)
            }
        }

    }

    val alumnoSeleccionado = MutableLiveData<AlumnoConCurso?>()
    fun buscarAlumnoPorDni(dni: String) {
        viewModelScope.launch {
            // Llamamos a la función de suspensión del DAO
            val resultado =repository.getAlumnoConCurso(dni)
            // Actualizamos el LiveData para que la UI se entere
            alumnoSeleccionado.postValue(resultado)
        }
    }
    val nombreCursoEncontrado = MutableLiveData<String>()
    fun buscarNombreCurso(id: Long) {
        viewModelScope.launch {
            // Suponiendo que tienes una función en el DAO que devuelve el Curso por ID
            val curso = repository.obtenerCursoPorId(id)

            if (curso != null) {
                nombreCursoEncontrado.postValue(curso.nombreCurso)
            } else {
                nombreCursoEncontrado.postValue("❌ Curso inexistente")
            }
        }
    }

}