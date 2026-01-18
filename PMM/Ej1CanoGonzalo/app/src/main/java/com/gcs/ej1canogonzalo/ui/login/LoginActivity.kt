package com.gcs.ej1canogonzalo.ui.login

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import com.gcs.ej1canogonzalo.R
import com.gcs.ej1canogonzalo.ui.consulta.ListaVehiculosActivity

class LoginActivity : AppCompatActivity() {

    private lateinit var viewModel: LoginViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        viewModel = LoginViewModel()

        val etLogin = findViewById<EditText>(R.id.etUser)
        val etPassword = findViewById<EditText>(R.id.etPassword)
        val btnAceptar = findViewById<Button>(R.id.btnAccept)

        btnAceptar.setOnClickListener {
            val login = etLogin.text.toString()
            val password = etPassword.text.toString()

            val usuario = viewModel.validarLogin(login, password)

            if (usuario != null) {
                val intent = Intent(this, ListaVehiculosActivity::class.java)
                intent.putExtra("usuario", usuario)
                startActivity(intent)
            } else {
                Toast.makeText(this, "Usuario o contraseña incorrectos", Toast.LENGTH_SHORT).show()
            }
        }
    }
}