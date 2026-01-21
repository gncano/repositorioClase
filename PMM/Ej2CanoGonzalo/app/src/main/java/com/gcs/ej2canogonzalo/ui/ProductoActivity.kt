package com.gcs.ej2canogonzalo.ui

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.ej2canogonzalo.data.local.DatosProductos
import com.gcs.ej2canogonzalo.databinding.ActivityProductoBinding

class ProductoActivity : AppCompatActivity() {

    private lateinit var binding: ActivityProductoBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityProductoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val categoria = intent.getStringExtra("categoria")

        val productosFiltrados = DatosProductos.productos.filter { it.categoria == categoria }

        val adapter = ProductoAdapter(productosFiltrados) { producto ->
            val intent = Intent(this, ModificarProductoActivity::class.java)
            intent.putExtra("codigoProducto", producto.codigo)
            startActivity(intent)
        }

        binding.rvProductos.layoutManager = LinearLayoutManager(this)
        binding.rvProductos.adapter = adapter
    }
}
