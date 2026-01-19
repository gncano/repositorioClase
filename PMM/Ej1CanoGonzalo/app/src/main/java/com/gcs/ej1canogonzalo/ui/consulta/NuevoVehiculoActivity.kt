package com.gcs.ej1canogonzalo.ui.consulta

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.gcs.ej1canogonzalo.R
import com.gcs.ej1canogonzalo.data.local.DatosVehiculos
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo

class NuevoVehiculoActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.nuevo_vehiculo)
        val etDNI = findViewById<EditText>(R.id.etDNI)
        val etNombre = findViewById<EditText>(R.id.etNombreApellidos)
        val etEmail = findViewById<EditText>(R.id.etEmail)
        val etMatricula = findViewById<EditText>(R.id.etMatricula)
        val etModelo = findViewById<EditText>(R.id.etModelo)
        val etFecha = findViewById<EditText>(R.id.etFechaEntrega)
        val etObservaciones = findViewById<EditText>(R.id.etObservaciones)
        val btnGuardar =
            findViewById<Button>(R.id.btnGuardarVehiculo)
        btnGuardar.setOnClickListener {
            val dni = etDNI.text.toString().trim()
            val nombre = etNombre.text.toString().trim()
            val email = etEmail.text.toString().trim()
            val matricula = etMatricula.text.toString().trim()
            val modelo = etModelo.text.toString().trim()
            val fecha = etFecha.text.toString().trim()
            val observaciones = etObservaciones.text.toString()
                .trim()
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