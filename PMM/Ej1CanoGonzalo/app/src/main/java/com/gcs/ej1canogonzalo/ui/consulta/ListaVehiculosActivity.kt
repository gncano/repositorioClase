package com.gcs.ej1canogonzalo.ui.consulta

import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.gcs.ej1canogonzalo.R
import com.gcs.ej1canogonzalo.data.local.DatosVehiculos
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario

class ListaVehiculosActivity : AppCompatActivity() {
    private lateinit var adapter: VehiculoAdapter


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_lista_vehiculos)

        val usuario = intent.getSerializableExtra("usuario") as Usuario
        val tvPerfil = findViewById<TextView>(R.id.tvPerfil)


        tvPerfil.text = when (usuario.perfil) {
            0 -> "Bienvenido " + usuario.login + "\n" + "tus permisos son de mecánico"

            1 -> "Bienvenido " + usuario.login + "\n" + "tus permisos son de recepción"

            else -> "Perfil desconocido"
        }
        val btnNuevoVehiculo = findViewById<Button>(R.id.btnNuevoVehiculo)
        btnNuevoVehiculo.visibility = if (usuario.perfil == 1) View.VISIBLE else View.GONE

        btnNuevoVehiculo.setOnClickListener {
            val intent = Intent(this, NuevoVehiculoActivity::class.java)
            startActivity(intent)
        }

        var vehiculosFiltrados = DatosVehiculos.vehiculos.toMutableList()

        if (usuario.perfil == 0) {
            vehiculosFiltrados =
                DatosVehiculos.vehiculos.filter { it.mecanicoId == usuario.id }.toMutableList()
        }

        val rvVehiculos = findViewById<RecyclerView>(R.id.rvVehiculos)
        rvVehiculos.layoutManager = LinearLayoutManager(this)

        adapter = VehiculoAdapter(
            vehiculosFiltrados,
            usuario
        ) { vehiculo ->
            DatosVehiculos.vehiculos.remove(vehiculo)
            vehiculosFiltrados.remove(vehiculo)
            adapter.notifyDataSetChanged()
        }
        rvVehiculos.adapter = adapter
    }
}