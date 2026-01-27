package com.gcs.ej1canogonzalo.ui.consulta

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.gcs.ej1canogonzalo.R
import com.gcs.ej1canogonzalo.data.local.DatosVehiculos
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo
import com.gcs.ej1canogonzalo.databinding.NuevoVehiculoBinding

class NuevoVehiculoActivity : AppCompatActivity() {

    private lateinit var binding: NuevoVehiculoBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = NuevoVehiculoBinding.inflate(layoutInflater)
        setContentView(binding.root)
        binding.btnGuardarVehiculo.setOnClickListener {
            val dni = binding.etDNI.text.toString().trim()
            val nombre = binding.etNombreApellidos.text.toString().trim()
            val email = binding.etEmail.text.toString().trim()
            val matricula = binding.etMatricula.text.toString().trim()
            val modelo = binding.etModelo.text.toString().trim()
            val fecha = binding.etFechaEntrega.text.toString().trim()
            val observaciones = binding.etObservaciones.text.toString().trim()
            if (dni.isEmpty() || nombre.isEmpty() || email.isEmpty() || matricula.isEmpty() || modelo.isEmpty() || fecha.isEmpty()) {
                Toast.makeText(this, "Todos los campos son obligatorios", Toast.LENGTH_SHORT)
                    .show()
                return@setOnClickListener
            }
            val nuevoVehiculo = Vehiculo(
                DNI = dni,
                nombre_apellidos = nombre,
                email = email,
                matricula = matricula,
                modelo = modelo,
                fechaEntrega = fecha,
                observaciones = observaciones,
                estado = "Pendiente",
                mecanicoId = 0
            )
            DatosVehiculos.vehiculos.add(nuevoVehiculo)
            Toast.makeText(this, "Vehículo añadido correctamente", Toast.LENGTH_SHORT)
                .show()
            finish()
        }
    }
}