package com.gcs.cano.datos.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(tableName = "rutina")
data class Rutina(
    @PrimaryKey(autoGenerate = true) val idRutina: Int = 0,
    val denominacion: String,
    val dificultad: String
) : Parcelable