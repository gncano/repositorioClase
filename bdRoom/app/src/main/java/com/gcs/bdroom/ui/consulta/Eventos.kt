package com.gcs.bdroommvvm.ui.consulta

import com.gcs.bdroommvvm.datos.local.entities.Alumno


interface Eventos {
    fun onUserClick(alumno: Alumno)
}
