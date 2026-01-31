package com.gcs.entregacanogonzalo.datos.local.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query
import com.gcs.entregacanogonzalo.datos.local.entidades.Libro
import com.gcs.entregacanogonzalo.datos.local.modelos.LibroConPrestamo

@Dao
interface LibroDao {

    @Insert
    fun insert(libro: Libro)

    @Query("""
        SELECT libro.isbn, libro.titulo, libro.autor,prestamo.personaId_FK, prestamo.fechaPrestamo
        FROM libro
        LEFT JOIN prestamo ON libro.isbn = prestamo.libroId_FK
                """
    )
    fun getAllLibros(): List<LibroConPrestamo>
}
