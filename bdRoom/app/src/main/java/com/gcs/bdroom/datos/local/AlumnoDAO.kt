package com.gcs.bdroommvvm.datos.local

import androidx.room.Insert
import androidx.room.Query
import androidx.room.Update
import androidx.room.Dao
import androidx.room.OnConflictStrategy
import com.gcs.bdroommvvm.datos.local.entities.Alumno

import kotlinx.coroutines.flow.Flow
@Dao
interface AlumnoDAO {
    // Para registrar un nuevo alumno
    @Insert(onConflict = OnConflictStrategy.IGNORE)
    suspend fun registrarAlumno(alumno: Alumno):Long

    @Query("SELECT EXISTS(SELECT * FROM tblAlumno " +
            "WHERE dni = :alumnoDni)")
    suspend fun existeAlumno2(alumnoDni: String): Boolean
    @Query("DELETE FROM tblAlumno WHERE dni = :alumnoDni")
    suspend fun eliminarAlumno(alumnoDni: String)

    @Query("SELECT * FROM tblAlumno")
    fun getAllAlumno(): Flow<List<Alumno>>
    // Usamos Flow para actualizaciones en tiempo real

    @Update
    suspend fun actualizarAlumno(alumno:Alumno)

    @Query("""
        SELECT tblAlumno.*, cursos.nombreCurso 
        FROM tblAlumno 
        INNER JOIN cursos ON tblAlumno.cursoIdRef = cursos.cursoId 
        WHERE tblAlumno.dni = :dni
    """)
    suspend fun obtenerAlumnoConCurso(dni: String): AlumnoConCurso?

}