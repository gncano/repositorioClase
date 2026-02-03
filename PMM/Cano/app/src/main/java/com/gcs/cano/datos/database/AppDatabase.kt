package com.gcs.cano.datos.database

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import com.gcs.cano.datos.dao.EjercicioDao
import com.gcs.cano.datos.dao.RutinaDao
import com.gcs.cano.datos.entidades.Ejercicio
import com.gcs.cano.datos.entidades.Rutina


@Database(
    entities = [Ejercicio::class, Rutina::class],
    version = 1,
    exportSchema = false
)
abstract class AppDatabase: RoomDatabase() {

    abstract fun rutinaDao(): RutinaDao
    abstract fun ejercicioDao(): EjercicioDao

    companion object {
        @Volatile
        private var INSTANCE: com.gcs.cano.datos.database.AppDatabase? = null

        fun getDatabase(context: Context): com.gcs.cano.datos.database.AppDatabase {
            return INSTANCE ?: synchronized(this) {
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    com.gcs.cano.datos.database.AppDatabase::class.java,
                    "gimnasio_db"
                )
                    .allowMainThreadQueries()
                    .build()
                INSTANCE = instance
                instance
            }
        }
    }
}