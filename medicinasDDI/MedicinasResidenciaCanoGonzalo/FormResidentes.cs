using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
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


        private void dgvResidentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Habilitar botones
                btnModificar.Enabled = true;
                btnBaja.Enabled = true;
            }
        }

        private void DarDeBajaResidente(int idResidente, int idUsuario)
        {


            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_BorrarResidente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdResidente", idResidente);
                cmd.Parameters.AddWithValue("@IdUsuarioModificacion", idUsuario);

                con.Open();
                int result = cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Residente dado de baja correctamente.");
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            int idResidente = Convert.ToInt32(dgvResidentes.SelectedRows[0].Cells["IdResidente"].Value);

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string habitacion = txtHabitacion.Text.Trim();

            ModificarResidente(idResidente, nombre, apellido, habitacion, _idUsuario);

            pnlModificar.Visible = false;

            btnBuscar.PerformClick();
        }

        private void ModificarResidente(int idResidente, string nombre, string apellido, string habitacion, int idUsuario)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_ModificarResidente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdResidente", idResidente);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellidos", apellido);
                cmd.Parameters.AddWithValue("@NumeroHabitacion", habitacion);
                cmd.Parameters.AddWithValue("@IdUsuarioModificacion", idUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Residente modificado correctamente.");
        }



        private void btnBuscar_Click_1(object sender, EventArgs e)
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

                    btnModificar.Enabled = false;
                    btnBaja.Enabled = false;

                    dgvResidentes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar residentes: " + ex.Message);
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            pnlAlta.Visible = true;
        }

        private void btnAltaAceptar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_AltaResidente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", txtAltaNombre.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txtAltaApellido.Text);
                cmd.Parameters.AddWithValue("@NumeroHabitacion", txtAltaHabitacion.Text.Trim());
                cmd.Parameters.AddWithValue("@IdUsuarioCreacion", _idUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            pnlAlta.Visible = false;
            txtAltaNombre.Clear();
            txtAltaApellido.Clear();
            txtAltaHabitacion.Clear();

            btnBuscar.PerformClick();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            if (dgvResidentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un residente primero.");
                return;
            }


            int idResidente = Convert.ToInt32(
                dgvResidentes.SelectedRows[0].Cells["IdResidente"].Value
            );


            if (_idRol != 1)
            {
                MessageBox.Show("Solo un usuario supervisor puede dar de baja.");
                return;
            }


            DialogResult confirm = MessageBox.Show(
                "¿Seguro que quieres dar de baja al residente?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;


            DarDeBajaResidente(idResidente, _idUsuario);


            btnBuscar.PerformClick();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvResidentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un residente primero.");
                return;
            }

            if (_idRol != 1)
            {
                MessageBox.Show("Solo un supervisor puede modificar residentes.");
                return;
            }

            txtNombre.Text = dgvResidentes.SelectedRows[0].Cells[1].Value.ToString();
            txtApellido.Text = dgvResidentes.SelectedRows[0].Cells[2].Value.ToString();
            txtHabitacion.Text = dgvResidentes.SelectedRows[0].Cells[3].Value.ToString();

            pnlModificar.Visible = true;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlta.Visible = false;
        }
    }
}

