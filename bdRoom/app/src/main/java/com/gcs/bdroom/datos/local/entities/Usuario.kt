package com.gcs.bdroommvvm.datos.local.entities

import android.os.Parcelable
import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import kotlinx.android.parcel.Parcelize

@Parcelize
@Entity(tableName="tblUsuarios")
data class Usuario(
    @PrimaryKey(autoGenerate=true)val id: Int=0,
    @ColumnInfo(name ="login") val login:String,
    val password:String
  ): Parcelable