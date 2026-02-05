package com.gcs.canogonzalo.datos.local.database

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import com.gcs.canogonzalo.datos.local.entidades.Libro
import com.gcs.canogonzalo.datos.local.entidades.Persona
import com.gcs.canogonzalo.datos.local.entidades.Prestamo
import com.gcs.canogonzalo.datos.local.dao.LibroDao
import com.gcs.canogonzalo.datos.local.dao.PersonaDao
import com.gcs.canogonzalo.datos.local.dao.PrestamoDao



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
                )
                    .allowMainThreadQueries()
                    .build()
                INSTANCE = instance
                instance
            }
        }
    }
}
