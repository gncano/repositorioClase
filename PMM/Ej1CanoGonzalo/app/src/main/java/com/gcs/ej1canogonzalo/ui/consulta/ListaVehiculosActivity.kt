package com.gcs.ej1canogonzalo.ui.consulta

import android.content.Intent
import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.ej1canogonzalo.data.local.DatosVehiculos
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.databinding.ActivityListaVehiculosBinding

class ListaVehiculosActivity : AppCompatActivity() {

    private lateinit var adapter: VehiculoAdapter
    private lateinit var binding: ActivityListaVehiculosBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityListaVehiculosBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val usuario = intent.getSerializableExtra("usuario") as Usuario

        binding.tvPerfil.text = when (usuario.perfil) {
            0 -> "Bienvenido ${usuario.login}\nTus permisos son de mecánico"
            1 -> "Bienvenido ${usuario.login}\nTus permisos son de recepción"
            else -> "Perfil desconocido"
        }

        binding.btnNuevoVehiculo.visibility =
            if (usuario.perfil == 1) View.VISIBLE else View.GONE

        binding.btnNuevoVehiculo.setOnClickListener {
            startActivity(Intent(this, NuevoVehiculoActivity::class.java))
        }

        var vehiculosFiltrados = DatosVehiculos.vehiculos.toMutableList()

        if (usuario.perfil == 0) {
            vehiculosFiltrados =
                DatosVehiculos.vehiculos.filter { it.mecanicoId == usuario.id }.toMutableList()
        }

        binding.rvVehiculos.layoutManager = LinearLayoutManager(this)

        adapter = VehiculoAdapter(
            vehiculosFiltrados,
            usuario
        ) { vehiculo ->
            DatosVehiculos.vehiculos.remove(vehiculo)
            vehiculosFiltrados.remove(vehiculo)
            adapter.notifyDataSetChanged()
        }

        binding.rvVehiculos.adapter = adapter
    }
}
