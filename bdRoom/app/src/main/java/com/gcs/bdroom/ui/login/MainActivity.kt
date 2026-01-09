package com.gcs.bdroommvvm.ui.login

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.viewModels
import androidx.appcompat.app.AppCompatActivity
import androidx.lifecycle.ViewModelProvider
import com.gcs.bdroom.databinding.ActivityMainBinding
import com.gcs.bdroommvvm.datos.local.AppDatabase
import com.gcs.bdroommvvm.ui.consulta.Consulta


class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private val viewModel: UserViewModel by viewModels {
        val database = AppDatabase.getDatabase(this)
        UserViewModelFactory(database.userDao(),database.alumnoDao(),database.cursoDao())
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)
        setupObservers()

        // 3. Configurar Eventos de UI
        binding.btnRegister.setOnClickListener {
            viewModel.registrar(binding.etUser.text.toString(), binding.etPass.text.toString())
        }

        binding.btnLogin.setOnClickListener {
            viewModel.login(binding.etUser.text.toString(), binding.etPass.text.toString())
        }
    }

    private fun setupObservers() {
        // Observar mensajes para Toasts
        viewModel.message.observe(this) { msg ->
            Toast.makeText(this, msg, Toast.LENGTH_SHORT).show()
        }

        // Observar navegación
        viewModel.navigateToProfile.observe(this) { userName ->
            userName?.let {
                val intent = Intent(this, Consulta::class.java).apply {
                    putExtra("USER_NAME", it)
                }
                startActivity(intent)
                viewModel.onNavigationDone() // Evita que se repita el intent al rotar pantalla
            }
        }
    }
}