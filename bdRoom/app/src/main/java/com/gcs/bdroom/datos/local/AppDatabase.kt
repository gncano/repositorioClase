package com.gcs.bdroommvvm.datos.local
import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.datos.local.entities.Curso
import com.gcs.bdroommvvm.datos.local.entities.Usuario

@Database(entities = [Usuario::class, Alumno::class, Curso::class], version = 1 )
abstract class AppDatabase : RoomDatabase() {
    abstract fun userDao(): UsuarioDao
    abstract fun alumnoDao(): AlumnoDAO
    abstract fun cursoDao(): CursoDAO
    companion object {
        @Volatile
        private var INSTANCE: AppDatabase? = null
        fun getDatabase(context: Context): AppDatabase {
            return INSTANCE ?: synchronized(this) {
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    AppDatabase::class.java,
                    "usuarios-db"
                ).build()
                INSTANCE = instance
                instance
            }
        }
    }
}