package com.gcs.ej1canogonzalo.ui.consulta

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

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_lista_vehiculos)

        val usuario = intent.getSerializableExtra("usuario") as Usuario
        val tvPerfil = findViewById<TextView>(R.id.tvPerfil)

        tvPerfil.text = when (usuario.perfil) {
            0 -> "Bienvenido " + usuario.login + "\n" +
                    "tus permisos son de mecánico"

            1 -> "Bienvenido " + usuario.login + "\n" +
                    "tus permisos son de recepción"

            else -> "Perfil desconocido"
        }

        val btnReparar = findViewById<Button>(R.id.btnReparar)
        val btnEntregar = findViewById<Button>(R.id.btnEntregar)
        var vehiculosFiltrados = DatosVehiculos.vehiculos

        if (usuario.perfil == 0) {
            btnReparar.visibility = View.VISIBLE
            btnEntregar.visibility = View.GONE
            vehiculosFiltrados = DatosVehiculos.vehiculos.filter { it.mecanicoId == usuario.id }

        } else {
            btnReparar.visibility = View.GONE
            btnEntregar.visibility = View.VISIBLE

        }

        val rvVehiculos = findViewById<RecyclerView>(R.id.rvVehiculos)
        rvVehiculos.layoutManager = LinearLayoutManager(this)
        rvVehiculos.adapter = VehiculoAdapter(vehiculosFiltrados, usuario)
        //TO DO

        val texto = vehiculosFiltrados.joinToString("\n\n") { v ->
            "Matrícula: ${v.matricula}\n" +
                    "Modelo: ${v.modelo}\n" +
                    "Estado: ${v.estado}"
        }

        rvVehiculos.text=texto
        //TO DO
        println(usuario.id)


    }
}