package com.gcs.ej2canogonzalo.ui

import android.content.Intent
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.ej2canogonzalo.R
import com.gcs.ej2canogonzalo.data.local.DatosCategorias
import com.gcs.ej2canogonzalo.databinding.ActivityMainBinding
import com.gcs.ej2canogonzalo.databinding.ActivityProductoBinding

class MainActivity : AppCompatActivity() {

    private lateinit var adapter: CategoriaAdapter
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate((layoutInflater))
        setContentView(binding.root)

        val categorias = DatosCategorias.categorias.toList()

        adapter = CategoriaAdapter(categorias) { categoria ->
            val intent = Intent(this, ProductoActivity::class.java)
            intent.putExtra("categoria", categoria.codigo)
            startActivity(intent)
        }

        binding.rvCategorias.layoutManager = LinearLayoutManager(this)
        binding.rvCategorias.adapter = adapter


    }
}