package com.gcs.bdroommvvm.ui.alumno

import android.os.Bundle
import android.widget.Toast

import androidx.activity.viewModels
import androidx.appcompat.app.AppCompatActivity
import androidx.lifecycle.lifecycleScope
import com.gcs.bdroom.databinding.ActivityUsuarioBinding
import com.gcs.bdroommvvm.datos.local.AppDatabase
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.datos.local.entities.Usuario
import com.gcs.bdroommvvm.ui.consulta.ConsultaViewModel
import com.gcs.bdroommvvm.ui.consulta.ConsultaViewModelFactory
import com.google.android.material.snackbar.Snackbar


import kotlinx.coroutines.launch
import kotlin.getValue

class AltaActivity : AppCompatActivity() {
    private lateinit var binding: ActivityUsuarioBinding
    private lateinit var usuario: Usuario
    private val alumnosViewModel: ConsultaViewModel by viewModels {
        val database = AppDatabase.getDatabase(this)
        ConsultaViewModelFactory(
            database.userDao(), database.alumnoDao(),
            database.cursoDao()
        )
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityUsuarioBinding.inflate(layoutInflater)
        setContentView(binding.root)
        setupObservers()
        binding.btnGrabar.setOnClickListener {
            val dni = binding.etDni.text.toString()
            if (dni.isNotEmpty()) {
                val dni = binding.etDni.text.toString()
                val nombre = binding.etNombre.text.toString()
                val curso = binding.etCurso.text.toString().toLong()
                val alumno = Alumno(dni, nombre, curso)

                lifecycleScope.launch {
                    // 1. Ejecutamos la inserción y esperamos el resultado
                    val resultado = alumnosViewModel.insertAlumno(alumno)

                }
            }
        }
    }

    private fun setupObservers() {
        alumnosViewModel.operacionExitosa.observe(this) { exito ->
            when {
                exito >= 0 -> {
                    Toast.makeText(this, "Alumno guardado correctamente", Toast.LENGTH_SHORT).show()
                    setResult(RESULT_OK) // Opcional, por si la pantalla anterior espera confirmación
                    finish() // Cerramos la pantalla solo si tuvo éxito
                }

                exito == -2L -> {
                    Snackbar.make(
                        binding.root,
                        "Todos los campos son obligatorios",
                        Snackbar.LENGTH_LONG
                    ).show()
                }

                exito == -7L -> {
                    Snackbar.make(
                        binding.root,
                        "No existe el curso del alumno",
                        Snackbar.LENGTH_LONG
                    )
                        .show()
                }

                else -> {
                    Snackbar.make(binding.root, "Error al guardar el alumno", Snackbar.LENGTH_LONG)
                        .show()
                }
            }

        }


    }
}
