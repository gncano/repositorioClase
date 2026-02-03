package com.gcs.cano.ui.detalle_activity

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.gcs.cano.databinding.ItemEjercicioBinding
import com.gcs.cano.datos.entidades.Ejercicio

class EjercicioAdapter(): RecyclerView.Adapter<EjercicioAdapter.EjercicioViewHolder>() {

    private var lista: List<Ejercicio> = emptyList()

    class EjercicioViewHolder(val binding: ItemEjercicioBinding) : RecyclerView.ViewHolder(binding.root) {

        fun bind(ejercicio: Ejercicio) {
            binding.tvIdEjercicio.text = ejercicio.idEjercicio.toString()
            binding.tvNombre.text = ejercicio.nombre
            binding.tvVolumen.text= ejercicio.volumenTrabajo.toString()


        }

    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EjercicioViewHolder {
        val binding= ItemEjercicioBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return EjercicioViewHolder(binding)
    }

    fun submitList(listaEjercicios: List<Ejercicio>) {
        lista = listaEjercicios
        notifyDataSetChanged()
    }

    override fun onBindViewHolder(holder: EjercicioViewHolder, position: Int) {
        val ejercicio= lista[position]
        holder.bind(ejercicio)
    }

    override fun getItemCount(): Int =lista.size
}