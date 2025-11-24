using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinasResidenciaCanoGonzalo
{
    public partial class FormResidentes : Form
    {

        private int _idUsuario;
        private int _idRol;
        public FormResidentes(int idUsuario, int idRol)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _idRol = idRol;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_BuscarResidente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtBuscarNombre.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvResidentes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar residentes: " + ex.Message);
            }
        }

        private void dgvResidentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita cabecera
            {
                // Habilitar botones
                btnModificar.Enabled = true;
                btnBaja.Enabled = true;
            }
        }
    }
}
