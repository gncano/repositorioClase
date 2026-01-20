package com.gcs.ej2canogonzalo.ui

import android.view.View
import android.view.ViewGroup
import android.view.ViewParent
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.gcs.ej2canogonzalo.data.local.entidades.Categoria

class CategoriaAdapter(
    private val categorias: List<Categoria>,
    private val onAccionClick: (Categoria) -> Unit
) : RecyclerView.Adapter<CategoriaAdapter.CategoriaViewHolder>(){

    class CategoriaViewHolder(view: View) : RecyclerView.ViewHolder(view){
        val tvCodigo: TextView =
    }
//TO DO terminan el adapter, es muy similar al del ejercicio anterior fijate en el como base
    override fun OnCreateViewHolder(parent: ViewGroup, viewType: Int): CategoriaViewHolder{

    }


}