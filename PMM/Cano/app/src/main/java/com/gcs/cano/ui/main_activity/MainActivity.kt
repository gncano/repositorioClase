package com.gcs.cano.ui.main_activity

import android.content.Intent
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.cano.R
import com.gcs.cano.databinding.ActivityMainBinding
import com.gcs.cano.datos.database.AppDatabase
import com.gcs.cano.datos.entidades.Rutina
import com.gcs.cano.ui.detalle_activity.DetalleActivity

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var adapter: RutinaAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        adapter = RutinaAdapter() { rutina ->
            val intent = Intent(this, DetalleActivity::class.java)
            intent.putExtra("rutina", rutina.idRutina)
            startActivity(intent)

        }

        binding.rvRutinas.layoutManager = LinearLayoutManager(this)
        binding.rvRutinas.adapter = adapter

        cargarRutinas()
    }

    override fun onResume() {
        super.onResume()
        cargarRutinas()
    }

    private fun cargarRutinas() {
        val db = AppDatabase.getDatabase(this)


        val listaRutinas = db.rutinaDao().getAllRutinas()
        adapter.submitList(listaRutinas)
    }
}