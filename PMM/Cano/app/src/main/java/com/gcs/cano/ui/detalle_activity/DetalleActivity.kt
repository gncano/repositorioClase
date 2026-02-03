package com.gcs.cano.ui.detalle_activity

import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.cano.databinding.ActivityDetalleBinding
import com.gcs.cano.databinding.DialogoNuevoEjercicioBinding
import com.gcs.cano.datos.database.AppDatabase
import com.gcs.cano.datos.entidades.Ejercicio
import com.gcs.cano.datos.entidades.Rutina

class DetalleActivity: AppCompatActivity() {
    private lateinit var binding: ActivityDetalleBinding
    private lateinit var adapter: EjercicioAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetalleBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val rutina= intent.getIntExtra("rutina",0)
        binding.btnAddEjercicio.setOnClickListener {
            addEjercicio(rutina)
        }



        adapter = EjercicioAdapter()
        binding.rvEjercicios.layoutManager = LinearLayoutManager(this)
        binding.rvEjercicios.adapter = adapter

        cargarEjercicios(rutina)
    }


    private fun cargarEjercicios(rutina: Int) {
        val db = AppDatabase.getDatabase(this)
        val listaEjercicios = db.ejercicioDao().getEjerciciosPorIdRutina(rutina)
        adapter.submitList(listaEjercicios)
    }

    private fun addEjercicio(rutina: Int){
        val dialogBinding = DialogoNuevoEjercicioBinding.inflate(layoutInflater)
        val db = AppDatabase.getDatabase(this)

        val item=db.rutinaDao().getRutinaPorId(rutina)
        AlertDialog.Builder(this)
            .setTitle("Nuevo ejercicio")
            .setMessage("Introduce el nombre y el volumen de repeticiones")
            .setView(dialogBinding.root)
            .setPositiveButton("Aceptar") { _, _ ->
                val nombreEj = dialogBinding.etnombre.text.toString()
                val volumen = Integer.parseInt( dialogBinding.etVolumen.text.toString())

                if (nombreEj.isBlank() || dialogBinding.etVolumen.text.isBlank()) {
                    Toast.makeText(this, "Debes rellenar todos los campos", Toast.LENGTH_SHORT)
                        .show()
                    return@setPositiveButton
                }


                val ejercicio = Ejercicio(
                    idEjercicio = 0,
                    nombre = nombreEj,
                    volumenTrabajo = volumen,
                    idRutina_fk = item.idRutina

                )

                db.ejercicioDao().insert(ejercicio)
                cargarEjercicios(rutina)
            }
            .setNegativeButton("Cancelar", null)
            .show()
    }
}