package com.gcs.ej1canogonzalo.data.local

import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo

object DatosVehiculos {
    val vehiculos = listOf(
        Vehiculo(
            matricula = "1234AAAA",
            modelo = "Ford",
            observaciones = "",
            estado = "Pendiente",
            mecanicoId = 0
        ),
        Vehiculo(
            matricula = "1234BBBB",
            modelo = "Ford",
            observaciones = "",
            estado = "Reparado",
            mecanicoId = 0
        ),
        Vehiculo(
            matricula = "1234CCCC",
            modelo = "Ford",
            observaciones = "Pendiente",
            estado = "",
            mecanicoId = 2
        ),
        Vehiculo(
            matricula = "1234DDDD",
            modelo = "Ford",
            observaciones = "",
            estado = "Pendiente",
            mecanicoId = 0
        )

    )
}