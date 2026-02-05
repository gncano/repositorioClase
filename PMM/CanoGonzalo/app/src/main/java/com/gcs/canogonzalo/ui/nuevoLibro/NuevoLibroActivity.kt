package com.gcs.canogonzalo.ui.nuevoLibro

import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.gcs.canogonzalo.databinding.NuevoLibroActivityBinding
import com.gcs.canogonzalo.datos.local.database.AppDatabase
import com.gcs.canogonzalo.datos.local.entidades.Libro

class NuevoLibroActivity : AppCompatActivity() {

    private lateinit var binding: NuevoLibroActivityBinding
    private lateinit var db: AppDatabase

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = NuevoLibroActivityBinding.inflate(layoutInflater)
        setContentView(binding.root)
        db = AppDatabase.getDatabase(this)

        binding.btnGuardar.setOnClickListener {
            val isbn = binding.etIsbn.text.toString()
            val titulo = binding.etTitulo.text.toString()
            val autor = binding.etAutor.text.toString()

            if (isbn.isBlank() || titulo.isBlank() || autor.isBlank()) {
                Toast.makeText(this, "Rellena todos los campos", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            db.libroDao().insert(Libro(isbn, titulo, autor))

            finish()
        }
        binding.btnCancelar.setOnClickListener { finish() }
    }
}