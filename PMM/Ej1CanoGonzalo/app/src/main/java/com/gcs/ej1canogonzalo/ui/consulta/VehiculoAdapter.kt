package com.gcs.ej1canogonzalo.ui.consulta

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo
import com.gcs.ej1canogonzalo.databinding.ItemVehiculoBinding

class VehiculoAdapter(
    private val vehiculos: MutableList<Vehiculo>,
    private val usuario: Usuario,
    private val onAccionClick: (Vehiculo) -> Unit
) : RecyclerView.Adapter<VehiculoAdapter.VehiculoViewHolder>() {

    class VehiculoViewHolder(val binding: ItemVehiculoBinding) :
        RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VehiculoViewHolder {
        val binding = ItemVehiculoBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return VehiculoViewHolder(binding)
    }

    override fun onBindViewHolder(holder: VehiculoViewHolder, position: Int) {
        val vehiculo = vehiculos[position]

        holder.binding.tvMatricula.text = vehiculo.matricula
        holder.binding.tvModelo.text = vehiculo.modelo
        holder.binding.tvEstado.text = vehiculo.estado

        if (usuario.perfil == 0) {
            holder.binding.btnAccion.text = "Cambiar estado"
            holder.binding.btnAccion.setOnLongClickListener {
                vehiculo.estado = when (vehiculo.estado) {
                    "Pendiente" -> "Reparado"
                    "Reparado" -> "Pendiente"
                    else -> vehiculo.estado
                }
                notifyItemChanged(position)
                true
            }
        } else {
            holder.binding.btnAccion.text = "Entregar"
            holder.binding.btnAccion.setOnClickListener {
                onAccionClick(vehiculo)
            }
        }

        holder.binding.btnAccion.isEnabled =
            if (usuario.perfil == 1) vehiculo.estado == "Reparado" else true
    }

    override fun getItemCount(): Int = vehiculos.size
}
