package com.gcs.entregacanogonzalo.datos.local.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(
    tableName = "prestamo",
    foreignKeys = [ForeignKey(
        entity = Libro::class,
        parentColumns = ["isbn"],
        childColumns = ["libroId_FK"],
        onDelete = ForeignKey.RESTRICT
    ),
        ForeignKey(
            entity = Persona::class,
            parentColumns = ["dni"],
            childColumns = ["personaId_FK"],
            onDelete = ForeignKey.RESTRICT
        )
    ],
    indices = [Index(value = ["personaId_FK"])]
)
data class Prestamo(
    @PrimaryKey(autoGenerate = true) val idPrestamo: Int = 0,
    val libroId_FK: String,
    val personaId_FK: String,
    val fechaPrestamo: String
) : Parcelable
