package com.gcs.bdroommvvm.ui.consulta


import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.gcs.bdroom.R
import com.gcs.bdroom.databinding.ItemUserBinding
import com.gcs.bdroommvvm.datos.local.entities.Alumno


class AlumnoAdapter(private val listener: Eventos) : ListAdapter<Alumno,
        AlumnoAdapter.AlumnoViewHolder>(UserDiffCallback()) {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): AlumnoViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_user, parent, false)
        return AlumnoViewHolder(view)
    }

    override fun onBindViewHolder(holder: AlumnoViewHolder, position: Int) {
        val user = getItem(position)
        holder.bind(user,listener)
    }

    class AlumnoViewHolder(view: View) : RecyclerView.ViewHolder(view) {
        val binding= ItemUserBinding.bind(view)

        fun bind(alumno: Alumno,listener: Eventos) {
            binding.txtDni.text=alumno.dni
            binding.txtNombre.text=alumno.nombre
            binding.tarjeta.setOnClickListener {
                listener.onUserClick(alumno)
            }
        }
    }

    class UserDiffCallback : DiffUtil.ItemCallback<Alumno>() {
        override fun areItemsTheSame(oldItem: Alumno, newItem: Alumno) = oldItem.dni == newItem.dni
        override fun areContentsTheSame(oldItem: Alumno, newItem: Alumno) = oldItem == newItem
    }
}