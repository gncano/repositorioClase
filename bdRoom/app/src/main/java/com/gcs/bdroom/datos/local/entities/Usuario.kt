package com.gcs.bdroommvvm.datos.local.entities


import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey



@Entity(tableName="tblUsuarios")
data class Usuario(
    @PrimaryKey(autoGenerate=true)val id: Int=0,
    @ColumnInfo(name ="login") val login:String,
    val password:String
  )