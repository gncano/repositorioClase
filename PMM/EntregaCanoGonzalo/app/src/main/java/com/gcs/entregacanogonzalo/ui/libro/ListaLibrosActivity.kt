package com.gcs.entregacanogonzalo.ui.libro

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.entregacanogonzalo.databinding.ActivityMainBinding
import com.gcs.entregacanogonzalo.datos.local.database.AppDatabase
import com.gcs.entregacanogonzalo.ui.libro.LibroAdapter

class ListaLibrosActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private lateinit var adapter: LibroAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        adapter = LibroAdapter()
        binding.rvLibros.layoutManager = LinearLayoutManager(this)
        binding.rvLibros.adapter = adapter

        cargarLibros()
    }

    private fun cargarLibros() {
        val db = AppDatabase.getDatabase(this)
        val listaLibros =
            db.libroDao().getAllLibrosConPrestamo() adapter . submitList (listaLibros)
    }

}