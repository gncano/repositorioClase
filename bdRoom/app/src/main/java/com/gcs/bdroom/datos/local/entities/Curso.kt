package com.gcs.bdroommvvm.datos.local.entities

import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity(tableName = "cursos")
data class Curso(
    @PrimaryKey(autoGenerate = true) val cursoId: Long = 0,
    val nombreCurso: String
)
