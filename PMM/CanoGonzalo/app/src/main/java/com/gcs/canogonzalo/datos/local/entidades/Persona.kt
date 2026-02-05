package com.gcs.canogonzalo.datos.local.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(tableName = "persona")
data class Persona(
    @PrimaryKey val dni: String,
    val nombre: String,
    val telefono: String
) : Parcelable
