package com.gcs.cano.datos.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(
    tableName = "ejercicio",
    foreignKeys = [ForeignKey(
        entity = Rutina::class,
        parentColumns = ["idRutina"],
        childColumns = ["idRutina_fk"],
        onDelete = ForeignKey.RESTRICT
    )],
    indices = [Index(value = ["idEjercicio"])]
)
data class Ejercicio(
    @PrimaryKey(autoGenerate = true) val idEjercicio: Int = 0,
    val nombre: String,
    val volumenTrabajo: Int,
    val idRutina_fk: Int
) : Parcelable
