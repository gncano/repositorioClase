package com.gcs.cano.datos.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query
import com.gcs.cano.datos.entidades.Rutina


@Dao
interface RutinaDao {

    @Query("""
        SELECT rutina.idRutina, rutina.denominacion, rutina.dificultad from rutina
    """)
    fun getAllRutinas(): List<Rutina>

    @Insert
    fun insert(rutina: Rutina)

    @Query("""
        SELECT * from rutina where idRutina = :rutina LIMIT 1
    """)
    fun getRutinaPorId(rutina: Int): Rutina
}