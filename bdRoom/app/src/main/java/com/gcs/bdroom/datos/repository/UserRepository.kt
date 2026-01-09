package com.gcs.bdroommvvm.datos.repository

import androidx.room.Query
import androidx.room.Update
import com.gcs.bdroommvvm.datos.local.AlumnoDAO
import com.gcs.bdroommvvm.datos.local.CursoDAO
import com.gcs.bdroommvvm.datos.local.UsuarioDao
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.datos.local.entities.Usuario


import kotlinx.coroutines.flow.Flow

class UserRepository(
    private val userDao: UsuarioDao,
    private val alumnoDao: AlumnoDAO,
    private val cursoDao: CursoDAO
) {
    // Comprobar si el usuario ya está en la DB
    suspend fun checkUserExists(user: String): Boolean = userDao.existeUsuario(user)

    // Operaciones de escritura
    suspend fun register(usuario: Usuario) = userDao.registrarUsuario(usuario)


    // Un solo metodo para obtener el usuario (Login)
    suspend fun login(user: String, pass: String): Usuario? {
        return userDao.login(user, pass)
    }



    suspend fun registerAlumno(alumno: Alumno):Long{
        val id= alumnoDao.registrarAlumno(alumno)
        return id

    }
    val allAlumno: Flow<List<Alumno>> = alumnoDao.getAllAlumno()



    suspend fun eliminarAlumno(alumnoDni:String)= alumnoDao.eliminarAlumno(alumnoDni)
    suspend fun updateAlumno(alumno: Alumno) =alumnoDao.actualizarAlumno(alumno)


    suspend fun existeCurso(id: Long)=cursoDao.existeCurso(id)
    suspend fun getAlumnoConCurso(alumnoDni:String)=alumnoDao.obtenerAlumnoConCurso(alumnoDni)
  suspend  fun obtenerCursoPorId(id: Long)=cursoDao.obtenerCursoPorId(id)
}
