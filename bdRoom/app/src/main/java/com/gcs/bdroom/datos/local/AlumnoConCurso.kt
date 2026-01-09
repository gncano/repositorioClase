package com.gcs.bdroommvvm.datos.local

import androidx.room.ColumnInfo
import androidx.room.Embedded
import com.gcs.bdroommvvm.datos.local.entities.Alumno


data class AlumnoConCurso(@Embedded val alumno: Alumno,
                          @ColumnInfo(name = "nombreCurso") val nombreDelCurso: String
)
