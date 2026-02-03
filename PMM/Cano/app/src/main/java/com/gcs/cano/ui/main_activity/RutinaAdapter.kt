package com.gcs.cano.ui.main_activity

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.RecyclerView
import com.gcs.cano.R
import com.gcs.cano.databinding.ItemRutinaBinding
import com.gcs.cano.datos.entidades.Rutina

class RutinaAdapter(
    private val onRutinaClick: (Rutina) -> Unit
) : RecyclerView.Adapter<RutinaAdapter.RutinaViewHolder>() {

    private var lista: List<Rutina> = emptyList()

    class RutinaViewHolder(val binding: ItemRutinaBinding) : RecyclerView.ViewHolder(binding.root) {

        fun bind(rutina: Rutina) {
            binding.tvIdRutina.text = rutina.idRutina.toString()
            binding.tvDenominacion.text = rutina.denominacion


            if (rutina.dificultad == "Baja") {
                itemView.setBackgroundColor(ContextCompat.getColor(itemView.context, R.color.white))
            } else if (rutina.dificultad == "Media") {

            } else {
                itemView.setBackgroundColor(ContextCompat.getColor(itemView.context, R.color.black))
            }

        }

    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): RutinaViewHolder {
        val binding= ItemRutinaBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return RutinaViewHolder(binding)
    }

    fun submitList(listaRutinas: List<Rutina>) {
        lista = listaRutinas
        notifyDataSetChanged()
    }

    override fun onBindViewHolder(holder: RutinaViewHolder, position: Int) {
        val rutina= lista[position]

        holder.bind(rutina)

        holder.binding.root.setOnClickListener {
            onRutinaClick(rutina)
        }
    }

    override fun getItemCount(): Int =lista.size
}