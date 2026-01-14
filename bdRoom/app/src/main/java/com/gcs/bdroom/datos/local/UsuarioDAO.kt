package com.gcs.bdroommvvm.datos.local


    import androidx.room.Dao
    import androidx.room.Insert
    import androidx.room.Query
    import com.gcs.bdroommvvm.datos.local.entities.Usuario

    import kotlinx.coroutines.flow.Flow

@Dao
    interface UsuarioDao {
        // Para registrar un nuevo usuario
        @Insert
        suspend fun registrarUsuario(user: Usuario)
        // Para buscar un usuario por sus credenciales (Login)
        @Query("SELECT * FROM tblUsuarios WHERE login = :userLogin" +
                " AND password = :userPass LIMIT 1")
        suspend fun login(userLogin: String, userPass: String): Usuario?

        // Para verificar si un nombre de usuario ya existe
        @Query("SELECT EXISTS(SELECT * FROM tblUsuarios " +
                "WHERE login = :userLogin)")
        suspend fun existeUsuario(userLogin: String): Boolean








    }