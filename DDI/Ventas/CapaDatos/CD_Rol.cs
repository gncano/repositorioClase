using CapaEntidad;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Rol
    {

        public List<Rol> listar()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idRol, Descripcion from ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["idRol"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }

            }
            return lista;
        }
    }
}
