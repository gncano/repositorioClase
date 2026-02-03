package com.gcs.cano.datos.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query
import com.gcs.cano.datos.entidades.Ejercicio


@Dao
interface EjercicioDao {

    @Query(
        """
        SELECT idEjercicio, nombre, volumenTrabajo, idRutina_fk  from ejercicio
    """
    )
    fun getAllEjercicios(): List<Ejercicio>

    @Insert
    fun insert(ejercicio: Ejercicio)

    @Query(
        """
        SELECT * from ejercicio  
        where idRutina_fk=:rutina
    """
    )
    fun getEjerciciosPorIdRutina(rutina: Int): List<Ejercicio>

}