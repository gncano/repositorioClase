package com.gcs.entregacanogonzalo.ui.libro

import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.entregacanogonzalo.databinding.ActivityMainBinding
import com.gcs.entregacanogonzalo.databinding.DialogoPrestamoBinding

import com.gcs.entregacanogonzalo.datos.local.database.AppDatabase
import com.gcs.entregacanogonzalo.datos.local.entidades.Prestamo
import com.gcs.entregacanogonzalo.datos.local.modelos.LibroConPrestamo

class ListaLibrosActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private lateinit var adapter: LibroAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        adapter = LibroAdapter { libro ->
            if (libro.personaId_FK == null) {
                pedirDniYFecha(libro)
            } else {
                confirmarDevolucion(libro)
            }
        }
        binding.rvLibros.layoutManager = LinearLayoutManager(this)
        binding.rvLibros.adapter = adapter

        cargarLibros()
    }

    private fun pedirDniYFecha(libro: LibroConPrestamo) {
        val dialogBinding = DialogoPrestamoBinding.inflate(layoutInflater)
        val db = AppDatabase.getDatabase(this)

        AlertDialog.Builder(this)
            .setTitle("Prestar libro")
            .setMessage("Introduce el DNI y la fecha del préstamo")
            .setView(dialogBinding.root)
            .setPositiveButton("Aceptar") { _, _ ->
                val dni = dialogBinding.etDni.text.toString()
                val fecha = dialogBinding.etFecha.text.toString()

                if (dni.isBlank() || fecha.isBlank()) {
                    Toast.makeText(this, "Debes rellenar todos los campos", Toast.LENGTH_SHORT)
                        .show()
                    return@setPositiveButton
                }

                val persona = db.personaDao().getPersonaPorDni(dni)
                if (persona == null) {
                    Toast.makeText(this, "El DNI no existe en la base de datos", Toast.LENGTH_SHORT)
                        .show()
                    return@setPositiveButton
                }

                val prestamo = Prestamo(
                    libroId_FK = libro.isbn,
                    personaId_FK = dni,
                    fechaPrestamo = fecha
                )

                db.prestamoDao().insert(prestamo)
                recargarLista()
            }
            .setNegativeButton("Cancelar", null)
            .show()
    }


    private fun confirmarDevolucion(libro: LibroConPrestamo) {
        val db = AppDatabase.getDatabase(this)
        AlertDialog.Builder(this)
            .setTitle("Devolver libro")
            .setMessage("¿Quieres marcar este libro como disponible?")
            .setPositiveButton("Sí") { _, _ ->
                db.prestamoDao().deletePrestamoDeLibro(libro.isbn)
                recargarLista()
            }
            .setNegativeButton("No", null)
            .show()
    }

    private fun recargarLista() {
        val db = AppDatabase.getDatabase(this)
        val lista = db.libroDao().getAllLibros()
        adapter.submitList(lista)
    }


    private fun cargarLibros() {
        val db = AppDatabase.getDatabase(this)
        val listaLibros = db.libroDao().getAllLibros()
        adapter.submitList(listaLibros)
    }

}