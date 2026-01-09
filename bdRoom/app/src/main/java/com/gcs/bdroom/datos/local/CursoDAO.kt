package com.gcs.bdroommvvm.datos.local

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query
import com.gcs.bdroommvvm.datos.local.entities.Curso


@Dao
interface CursoDAO {
    @Insert
    suspend fun insertarCurso(curso: Curso): Long
    @Query("SELECT * FROM cursos WHERE cursoId = :id")
    suspend fun obtenerCursoPorId(id: Long): Curso?
    @Query("SELECT EXISTS(SELECT 1 FROM cursos WHERE cursoId = :id)")
    suspend fun existeCurso(id: Long): Boolean
}