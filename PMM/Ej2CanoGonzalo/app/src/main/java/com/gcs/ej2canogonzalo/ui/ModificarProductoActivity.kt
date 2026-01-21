package com.gcs.ej2canogonzalo.ui

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.gcs.ej2canogonzalo.data.local.DatosProductos
import com.gcs.ej2canogonzalo.data.local.entidades.Producto
import com.gcs.ej2canogonzalo.databinding.ActivityModificarProductoBinding

class ModificarProductoActivity : AppCompatActivity() {

    private lateinit var binding: ActivityModificarProductoBinding
    private lateinit var producto: Producto

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityModificarProductoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val codigoProducto = intent.getStringExtra("codigoProducto")
        producto = DatosProductos.productos.first { it.codigo == codigoProducto }

        binding.tvCodigo.text = producto.codigo
        binding.tvCategoria.text = producto.categoria
        binding.tvDenominacion.text = producto.denominacion
        binding.tvColor.text = producto.color
        binding.etPrecio.setText(producto.precio.toString())
        binding.etExistencias.setText(producto.existencias.toString())

        binding.btnGuardar.setOnClickListener {
            producto.precio = binding.etPrecio.text.toString().toFloat()
            producto.existencias = binding.etExistencias.text.toString().toInt()
            finish()
        }

        binding.btnCancelar.setOnClickListener {
            finish()
        }
    }
}
