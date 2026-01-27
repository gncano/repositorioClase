package com.gcs.ej1canogonzalo.ui.login

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.gcs.ej1canogonzalo.databinding.ActivityMainBinding
import com.gcs.ej1canogonzalo.ui.consulta.ListaVehiculosActivity

class LoginActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var viewModel: LoginViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        viewModel = LoginViewModel()

        binding.btnAccept.setOnClickListener {
            val login = binding.etUser.text.toString()
            val password = binding.etPassword.text.toString()

            val usuario = viewModel.validarLogin(login, password)

            if (usuario != null) {
                val intent = Intent(this, ListaVehiculosActivity::class.java)
                intent.putExtra("usuario", usuario)
                startActivity(intent)
            } else {
                Toast.makeText(
                    this,
                    "Usuario o contraseña incorrectos",
                    Toast.LENGTH_SHORT
                ).show()
            }
        }
    }
}
