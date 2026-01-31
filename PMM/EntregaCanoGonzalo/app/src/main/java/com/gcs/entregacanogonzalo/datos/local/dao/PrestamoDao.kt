package com.gcs.entregacanogonzalo.datos.local.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.gcs.entregacanogonzalo.datos.local.entidades.Prestamo

@Dao
interface PrestamoDao {

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insert(prestamo: Prestamo)

    @Query("DELETE FROM prestamo WHERE libroId_FK = :isbn")
    fun deletePrestamoDeLibro(isbn: String)

    @Query("SELECT * FROM prestamo WHERE libroId_FK = :isbn LIMIT 1")
    fun getPrestamoDeLibro(isbn: String): Prestamo?
}
