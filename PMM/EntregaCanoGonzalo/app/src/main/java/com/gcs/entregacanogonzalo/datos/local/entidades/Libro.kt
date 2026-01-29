package com.gcs.entregacanogonzalo.datos.local.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(tableName = "libros")
data class Libro(
    @PrimaryKey(autoGenerate = true) val isbn: String,
    val titulo: String,
    val autor: String

) : Parcelable
