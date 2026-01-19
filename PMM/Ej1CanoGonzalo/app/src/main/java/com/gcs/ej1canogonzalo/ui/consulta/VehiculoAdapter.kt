package com.gcs.ej1canogonzalo.ui.consulta

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.gcs.ej1canogonzalo.R
import com.gcs.ej1canogonzalo.data.local.entidades.Usuario
import com.gcs.ej1canogonzalo.data.local.entidades.Vehiculo

class VehiculoAdapter(
    private val vehiculos: MutableList<Vehiculo>,
    private val usuario: Usuario,
    private val onAccionClick: (Vehiculo) -> Unit
) : RecyclerView.Adapter<VehiculoAdapter.VehiculoViewHolder>() {
    class VehiculoViewHolder(view: View) : RecyclerView.ViewHolder(view) {
        val tvMatricula: TextView = view.findViewById(R.id.tvMatricula)
        val tvModelo: TextView = view.findViewById(R.id.tvModelo)
        val tvEstado: TextView = view.findViewById(R.id.tvEstado)
        val btnAccion: Button = view.findViewById(R.id.btnAccion)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VehiculoViewHolder {
        val view =
            LayoutInflater.from(parent.context).inflate(R.layout.item_vehiculo, parent, false)
        return VehiculoViewHolder(view)
    }

    override fun onBindViewHolder(holder: VehiculoViewHolder, position: Int) {
        val vehiculo = vehiculos[position]
        holder.tvMatricula.text = vehiculo.matricula
        holder.tvModelo.text = vehiculo.modelo
        holder.tvEstado.text = vehiculo.estado

        holder.btnAccion.text = if (usuario.perfil == 0) {
            "Cambiar estado"

        } else "Entregar"
        if (usuario.perfil == 0) {
            holder.btnAccion.text = "Cambiar estado"
            holder.btnAccion.setOnLongClickListener {
                vehiculo.estado = when (vehiculo.estado) {
                    "Pendiente" -> "Reparado"
                    "Reparado" -> "Pendiente"
                    else -> vehiculo.estado
                }
                notifyItemChanged(position)
                true
            }

        } else {
            holder.btnAccion.text = "Entregar"
            holder.btnAccion.setOnClickListener {
                onAccionClick(vehiculo)
            }
        }

        if (usuario.perfil == 1) {
            holder.btnAccion.isEnabled = vehiculo.estado == "Reparado"
        } else {
            holder.btnAccion.isEnabled = true
        }





    }

    override fun getItemCount(): Int = vehiculos.size
}