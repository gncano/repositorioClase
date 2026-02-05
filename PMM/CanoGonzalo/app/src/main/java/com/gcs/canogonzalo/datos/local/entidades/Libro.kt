package com.gcs.canogonzalo.datos.local.entidades

import android.os.Parcelable
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.parcelize.Parcelize

@Parcelize
@Entity(tableName = "libro")
data class Libro(
    @PrimaryKey val isbn: String,
    val titulo: String,
    val autor: String

) : Parcelable
