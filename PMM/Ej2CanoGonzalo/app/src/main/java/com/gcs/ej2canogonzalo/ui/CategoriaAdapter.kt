package com.gcs.ej2canogonzalo.ui

import android.content.Intent
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.gcs.ej2canogonzalo.data.local.entidades.Categoria
import com.gcs.ej2canogonzalo.databinding.ItemCategoriaBinding

class CategoriaAdapter(
    private val categorias: List<Categoria>,
    private val onAccionClick: (Categoria) -> Unit
) : RecyclerView.Adapter<CategoriaAdapter.CategoriaViewHolder>() {

    class CategoriaViewHolder(val binding: ItemCategoriaBinding) :
        RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CategoriaViewHolder {
        val binding = ItemCategoriaBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return CategoriaViewHolder(binding)
    }

    override fun onBindViewHolder(holder: CategoriaViewHolder, position: Int) {
        val categoria = categorias[position]

        holder.binding.tvCodigo.text = categoria.codigo
        holder.binding.tvDenominacion.text = categoria.denominacion

        holder.binding.root.setOnClickListener {
            onAccionClick(categoria)
        }
    }

    override fun getItemCount(): Int = categorias.size


}