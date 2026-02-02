package com.gcs.entregacanogonzalo.ui.persona

import android.os.Bundle
import android.view.LayoutInflater
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.viewbinding.ViewBinding
import com.gcs.entregacanogonzalo.databinding.ActivityPersonaBinding
import com.gcs.entregacanogonzalo.datos.local.database.AppDatabase
import com.gcs.entregacanogonzalo.datos.local.entidades.Persona

class PersonaActivity : AppCompatActivity() {
    private lateinit var binding: ActivityPersonaBinding
    private lateinit var db: AppDatabase

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityPersonaBinding.inflate(layoutInflater)
        setContentView(binding.root)

        db = AppDatabase.getDatabase(this)

        binding.btnGuardar.setOnClickListener {
            val dni = binding.etDni.text.toString()
            val nombre = binding.etNombre.text.toString()
            val telefono = binding.etTelefono.text.toString()

            if (dni.isBlank() || nombre.isBlank() || telefono.isBlank()) {
                Toast.makeText(this, "Rellena todos los campos", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            db.personaDao().insert(Persona(dni, nombre, telefono))
            finish()
        }
        binding.btnCancelar.setOnClickListener { finish() }
    }

}