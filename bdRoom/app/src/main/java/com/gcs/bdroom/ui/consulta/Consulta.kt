package com.gcs.bdroommvvm.ui.consulta

import android.content.Intent
import android.os.Bundle
import androidx.activity.result.contract.ActivityResultContracts
import androidx.activity.viewModels
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.gcs.bdroom.databinding.ActivityConsultaBinding
import com.gcs.bdroommvvm.datos.local.AppDatabase
import com.gcs.bdroommvvm.datos.local.entities.Alumno
import com.gcs.bdroommvvm.ui.alumno.AltaActivity
import com.gcs.bdroommvvm.ui.alumno.AlumnoActivity


class Consulta : AppCompatActivity(), Eventos {
    private lateinit var binding: ActivityConsultaBinding
    private lateinit var adapter: AlumnoAdapter
    private val alumnosViewModel: ConsultaViewModel by viewModels {
       val database = AppDatabase.getDatabase(this)
       ConsultaViewModelFactory(database.userDao(),database.alumnoDao(),
           database.cursoDao())
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityConsultaBinding.inflate(layoutInflater)
        setContentView(binding.root)

        adapter = AlumnoAdapter(this)
        configurarRecycler()

        // OBSERVADOR: Aquí ocurre la magia
        alumnosViewModel.allAlumnos.observe(this) { listaAlumnos ->
            // El adapter recibe la nueva lista y se actualiza solo
            adapter.submitList(listaAlumnos)
        }
        binding.fabAddUser.setOnClickListener {
            val intent = Intent(this, AltaActivity::class.java)
            startActivity(intent)
        }
    }

    private fun configurarRecycler() {
        with(binding.recyclerViewUsers) {
            adapter = this@Consulta.adapter
            layoutManager = LinearLayoutManager(this@Consulta)
            setHasFixedSize(true)
        }
    }

    override fun onUserClick(alumno: Alumno) {
        val intent = Intent(this@Consulta,  AlumnoActivity::class.java)
        intent.putExtra("EXTRA_USER",alumno)
        resultadoActivity.launch(intent)
    }
    var resultadoActivity=registerForActivityResult(ActivityResultContracts.StartActivityForResult())
    {

    }

}

