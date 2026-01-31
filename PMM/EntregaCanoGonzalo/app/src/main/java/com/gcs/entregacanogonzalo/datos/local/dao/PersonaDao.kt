package com.gcs.entregacanogonzalo.datos.local.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.gcs.entregacanogonzalo.datos.local.entidades.Persona

@Dao
interface PersonaDao {

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert(persona: Persona)

    @Query("SELECT * FROM persona WHERE dni = :dni LIMIT 1")
    fun getPersonaPorDni(dni: String): Persona?
}


