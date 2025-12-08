
package practicaexamensax;

/**
 *
 * @author gcano
 */
public class Plato {
    
    private String id;
    private String nombre;
    private float precio;
    private String tipo;
    private String ingredientes;

    public Plato() {
    }

    public String getId() {
        return id;
    }

    public String getNombre() {
        return nombre;
    }

    public float getPrecio() {
        return precio;
    }

    public String getTipo() {
        return tipo;
    }

    public String getIngredientes() {
        return ingredientes;
    }

    public void setId(String id) {
        this.id = id;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public void setIngredientes(String ingredientes) {
        this.ingredientes = ingredientes;
    }
    
   

    @Override
    public String toString() {
        return "Plato{" +
                "id='" + id + '\'' +
                ", nombre='" + nombre + '\'' +
                ", precio='" + precio + '\'' +
                ", tipo=" + tipo +
                ", ingredientes='" + ingredientes + '\'' +
                "}\n";
    }
}

