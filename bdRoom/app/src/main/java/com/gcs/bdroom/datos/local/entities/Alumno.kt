package com.gcs.bdroommvvm.datos.local.entities

import android.os.Parcelable
import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import kotlinx.android.parcel.Parcelize

@Parcelize
@Entity(tableName="tblAlumno",
        foreignKeys = [
    ForeignKey(
        entity = Curso::class,
        // Entidad con la que se relaciona
        parentColumns = ["cursoId"],
        // Clave primaria en el Padre
        childColumns = ["cursoIdRef"],
        // Clave foránea en esta entidad
        onDelete = ForeignKey.CASCADE
    // Si borras el curso, se borran sus alumnos
    )
],
    indices = [Index(value = ["cursoIdRef"])]
// Recomendado para mejorar la velocidad de búsqueda
)
data class Alumno(
    @PrimaryKey val dni:String ,
    val nombre:String,
    val cursoIdRef: Long
    ): Parcelable