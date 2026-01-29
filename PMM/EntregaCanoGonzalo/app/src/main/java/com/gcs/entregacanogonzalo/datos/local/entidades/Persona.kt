package com.gcs.entregacanogonzalo.datos.local.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(tableName = "personas")
data class Persona(
    @PrimaryKey val dni: String,
    val nombre: String,
    val telefono: String
) : Parcelable
