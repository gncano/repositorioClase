package com.gcs.entregacanogonzalo.ui.libro

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.gcs.entregacanogonzalo.databinding.ItemLibroBinding
import com.gcs.entregacanogonzalo.datos.local.modelos.LibroConPrestamo

class LibroAdapter(
    private val onLibroClick: (LibroConPrestamo) -> Unit,
    private val onDeleteClick: (LibroConPrestamo) -> Unit
) : RecyclerView.Adapter<LibroAdapter.LibroViewHolder>() {

    private var lista: List<LibroConPrestamo> = emptyList()


    class LibroViewHolder(val binding: ItemLibroBinding) :
        RecyclerView.ViewHolder(binding.root) {

        fun bind(libro: LibroConPrestamo) {
            binding.tvTitulo.text = libro.titulo

            if (libro.personaId_FK == null) {
                binding.tvEstado.text = "Disponible"
                binding.tvPrestamo.text = ""
                binding.tvFecha.text = ""
            } else {
                binding.tvEstado.text = "Prestado"
                binding.tvPrestamo.text = "A: ${libro.personaId_FK}"
                binding.tvFecha.text = libro.fechaPrestamo ?: ""
            }
        }
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): LibroViewHolder {
        val binding = ItemLibroBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return LibroViewHolder(binding)
    }


    fun submitList(listaLibros: List<LibroConPrestamo>) {
        lista = listaLibros
        notifyDataSetChanged()
    }


    override fun onBindViewHolder(holder: LibroViewHolder, position: Int) {
        val libro = lista[position]


        holder.bind(libro)


        holder.binding.root.setOnClickListener {
            onLibroClick(libro)
        }

        holder.binding.btnEliminar.setOnClickListener {
            onDeleteClick(libro)
        }
    }

    override fun getItemCount(): Int = lista.size
}
