package com.gcs.bdroommvvm.ui.alumno

import android.app.Activity
import android.content.Intent
import android.graphics.Color
import android.os.Build
import android.os.Bundle
import android.widget.Toast
import androidx.activity.viewModels
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContentProviderCompat.requireContext
import androidx.core.widget.doAfterTextChanged
import androidx.lifecycle.lifecycleScope
import com.gcs.bdroom.databinding.ActivityAlumnoBinding
import com.gcs.bdroommvvm.datos.local.AlumnoConCurso
import com.gcs.bdroommvvm.datos.local.AppDatabase
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.ui.consulta.ConsultaViewModel
import com.gcs.bdroommvvm.ui.consulta.ConsultaViewModelFactory
import com.google.android.material.snackbar.Snackbar



import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import kotlin.getValue

class AlumnoActivity : AppCompatActivity() {
    private lateinit var binding: ActivityAlumnoBinding
    private val alumnosViewModel: ConsultaViewModel by viewModels {
        val database = AppDatabase.getDatabase(this)
        ConsultaViewModelFactory(
            database.userDao(), database.alumnoDao(),
            database.cursoDao()
        )
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityAlumnoBinding.inflate(layoutInflater)
        setContentView(binding.root)
        setupObservers()
        // Recuperar el alumno del Intent
        val alumno = if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.TIRAMISU) {
            intent.getParcelableExtra("EXTRA_USER", Alumno::class.java)
        } else {
            @Suppress("DEPRECATION")
            intent.getParcelableExtra<Alumno>("EXTRA_USER")
        }
        if (alumno != null) {
            alumnosViewModel.buscarAlumnoPorDni(alumno.dni)
        }

        binding.btnGrabar.setOnClickListener {
            grabar()
        }
        binding.btnCancelar.setOnClickListener {
            // mostrarDatosAlumno(alumno)
            setResult(RESULT_OK) // Opcional, por si la pantalla anterior espera confirmación
            finish()
        }
        binding.btnEliminar.setOnClickListener {
            eliminar(alumno);
        }
        binding.etCurso.doAfterTextChanged { text ->
            val cursoId = text.toString().toLongOrNull()

            if (cursoId != null) {
                // Si hay un número válido, pedimos al ViewModel que busque el nombre
                alumnosViewModel.buscarNombreCurso(cursoId)
            } else {
                // Si el campo está vacío o no es un número, borramos la denominación
                binding.tvNombreCurso.text = ""
            }
        }

    }

    private fun mostrarDatosAlumno(datos: AlumnoConCurso) {
        datos?.let {
            val dni = binding.etDni.text.toString()
            if (dni.isNotEmpty()) {
                alumnosViewModel.buscarAlumnoPorDni(dni)
            }
            binding.etNombre.setText(datos.alumno.nombre)
            binding.etDni.setText(datos.alumno.dni)
            binding.etCurso.setText(datos.alumno.cursoIdRef.toString())

            // 'datos.nombreDelCurso' viene del JOIN
            binding.tvNombreCurso.text = datos.nombreDelCurso
        }

    }


    private fun grabar() {
        val dni = binding.etDni.text.toString()
        val nombre = binding.etNombre.text.toString()
        val curso = binding.etCurso.text.toString().toLong()

        val alumno = Alumno(dni, nombre, curso)

        lifecycleScope.launch {
            // 1. Ejecutamos la actualizacion y esperamos el resultado
            alumnosViewModel.updateAlumno(alumno)
        }
    }

    private fun eliminar(alumno: Alumno?) {
        alumno?.let {
            AlertDialog.Builder(this)
                .setTitle("Eliminar alumno")
                .setMessage("¿Estás seguro de que quieres borrar tu alumno? Esta acción no se puede deshacer.")
                .setPositiveButton("Sí, eliminar") { _, _ ->
                    // Ejecutar la eliminación en segundo plano
                    lifecycleScope.launch(Dispatchers.IO) {
                        alumnosViewModel.eliminarAlumno(alumno)
                    }
                }
                .setNegativeButton("Cancelar", null)
                .show()
        }
    }

    private fun setupObservers() {


// 1. Configuras el observador (esto suele ir en el onCreate o onViewCreated)

        alumnosViewModel.operacionExitosa.observe(this) { exito ->
            when {
                exito == 4L -> completarAccion("Alumno eliminado correctamente")
                exito >= 0 -> completarAccion("Alumno guardado correctamente")
                exito == -2L -> mostrarError("Todos los campos son obligatorios")
                exito == -7L -> mostrarError("Curso Inexistente")
                else -> mostrarError("Se ha producido algún error")
            }
        }
        alumnosViewModel.alumnoSeleccionado.observe(this) { datos ->
            if (datos != null) {
                mostrarDatosAlumno(datos)
            } else {
                Toast.makeText(this@AlumnoActivity, "Alumno no encontrado", Toast.LENGTH_SHORT)
                    .show()
            }
        }
        alumnosViewModel.nombreCursoEncontrado.observe(this) { nombre ->
            binding.tvNombreCurso.text = nombre

            // Opcional: poner el campo en rojo si no existe
            if (nombre.contains("inexistente")) {
                binding.tvNombreCurso.setTextColor(Color.RED)
            } else {
                binding.tvNombreCurso.setTextColor(Color.BLACK)
            }
        }
    }

    private fun completarAccion(mensaje: String) {
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show()
        setResult(RESULT_OK)
        finish()
    }

    private fun mostrarError(mensaje: String) {
        Snackbar.make(binding.root, mensaje, Snackbar.LENGTH_LONG).show()
    }


}





