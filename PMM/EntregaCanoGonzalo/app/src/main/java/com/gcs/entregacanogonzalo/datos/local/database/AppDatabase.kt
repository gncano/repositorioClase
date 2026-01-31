package com.gcs.entregacanogonzalo.datos.local.database

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import com.gcs.entregacanogonzalo.datos.local.entidades.Libro
import com.gcs.entregacanogonzalo.datos.local.entidades.Persona
import com.gcs.entregacanogonzalo.datos.local.entidades.Prestamo
import com.gcs.entregacanogonzalo.datos.local.dao.LibroDao
import com.gcs.entregacanogonzalo.datos.local.dao.PersonaDao
import com.gcs.entregacanogonzalo.datos.local.dao.PrestamoDao



@Database(
    entities = [Libro::class, Persona::class, Prestamo::class],
    version = 1,
    exportSchema = false
)
abstract class AppDatabase : RoomDatabase() {

    abstract fun libroDao(): LibroDao
    abstract fun personaDao(): PersonaDao
    abstract fun prestamoDao(): PrestamoDao

    companion object {
        @Volatile
        private var INSTANCE: AppDatabase? = null

        fun getDatabase(context: Context): AppDatabase {
            return INSTANCE ?: synchronized(this) {
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    AppDatabase::class.java,
                    "biblioteca_db"
                ).build()
                INSTANCE = instance
                instance
            }
        }
    }
}
