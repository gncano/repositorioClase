package com.gcs.ej1canogonzalo.data.local

import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo

object DatosVehiculos {
    val vehiculos = mutableListOf<Vehiculo>(
        Vehiculo(
            DNI = "12345678A",
            nombre_apellidos = "Carlos Martínez López",
            email = "carlos.martinez@example.com",
            matricula = "1234ABC",
            modelo = "Seat Ibiza",
            fechaEntrega = "2024-01-10",
            observaciones = "Ruidos en el motor",
            estado = "Pendiente",
            mecanicoId = 0
        ),
        Vehiculo(
            DNI = "87654321B",
            nombre_apellidos = "Laura Gómez Pérez",
            email = "laura.gomez@example.com",
            matricula = "5678DEF",
            modelo = "Volkswagen Golf",
            fechaEntrega = "2024-01-12",
            observaciones = "Cambio de aceite",
            estado = "Reparando",
            mecanicoId = 0
        ),
        Vehiculo(
            DNI = "11223344C",
            nombre_apellidos = "Miguel Torres Ruiz",
            email = "miguel.torres@example.com",
            matricula = "9012GHI",
            modelo = "Ford Focus",
            fechaEntrega = "2024-01-15",
            observaciones = "Problemas eléctricos",
            estado = "Reparado",
            mecanicoId = 2
        )
    )
}