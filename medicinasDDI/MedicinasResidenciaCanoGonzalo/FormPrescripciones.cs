using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MedicinasResidenciaCanoGonzalo
{
    public partial class FormPrescripciones : Form
    {
        private int _idUsuario;
        private int _idRol;
        public FormPrescripciones(int idUsuario, int idRol)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _idRol = idRol;

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Activas");
            cmbEstado.Items.Add("Inactivas");
            cmbEstado.SelectedIndex = 0;

        }

        private void FormPrescripciones_Load(object sender, EventArgs e)
        {
            btnAddPrescipcion.Visible = _idRol == 1;
        }

        private void txtIdResidente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdResidente.Text))
            {
                int idResidente;
                if (int.TryParse(txtIdResidente.Text, out idResidente))
                {
                    // Realizar la consulta a la base de datos para obtener el nombre del residente
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
                    {
                        string query = "SELECT Nombre FROM Residente WHERE IdResidente = @IdResidente";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@IdResidente", idResidente);

                            con.Open();
                            var resultado = cmd.ExecuteScalar();
                            if (resultado != null)
                            {
                                lblNombre.Text = resultado.ToString();
                            }
                            else
                            {
                                lblNombre.Text = "Residente no encontrado";
                            }
                        }
                    }
                }
                else
                {
                    // Si el ID no es un número válido
                    lblNombre.Text = "ID inválido";
                }
            }
            else
            {
                // Si el campo está vacío
                lblNombre.Text = string.Empty;
            }
        }

        private void dgvPrescripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Habilitar botones
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text.Trim();

            string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
            string estadoParametro;
            switch (estadoSeleccionado)
            {
                case "Activas":
                    estadoParametro = "A";
                    break;
                case "Inactivas":
                    estadoParametro = "I";
                    break;
                default:
                    estadoParametro = "Todos";
                    break;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarPrescripcionPorResidente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreResidente", nombre);
                cmd.Parameters.AddWithValue("@Estado", estadoParametro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPrescripciones.DataSource = dt;
                dgvPrescripciones.ReadOnly = true;
                dgvPrescripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void btnAddPrescipcion_Click_1(object sender, EventArgs e)
        {
            pnlAddPrescripcion.Visible = true;


            txtIdResidente.Text = string.Empty;
            lblNombre.Text = string.Empty;
            cmbNombreMedicamento.Items.Clear();
            cmbFrecuencia.Items.Clear();
            txtLaboratorio.Text = string.Empty;
            txtDosis.Text = string.Empty;
            txtPautas.Text = string.Empty;

            List<string> medicamentos = new List<string>
    {
        "Paracetamol", "Vitamina C", "Ibuprofeno", "Omega 3", "Metformina", "Vitamina D", "Amoxicilina", "Hierro", "Aspirina", "Magnesio", "Loratadina", "Calcio", "Simvastatina", "Vitamina B12", "Omeprazol", "Zinc", "Metoprolol", "Vitamina E", "Furosemida", "Vitamina A"
    };


            List<string> frecuencias = new List<string>
    {
        "Cada 8h", "Diario", "Cada 12h"
    };


            cmbNombreMedicamento.Items.Clear();
            cmbFrecuencia.Items.Clear();

            cmbNombreMedicamento.Items.AddRange(medicamentos.ToArray());
            cmbFrecuencia.Items.AddRange(frecuencias.ToArray());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (_idRol != 1) // 1 = Supervisor
            {
                MessageBox.Show("No tienes permisos para modificar prescripciones.");
                return;
            }

            if (dgvPrescripciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una prescripción para modificar.");
                return;
            }

            int idPrescripcion = Convert.ToInt32(dgvPrescripciones.CurrentRow.Cells["IdPrescripcion"].Value);
            int idUsuarioModificacion = _idUsuario; // Suponiendo que _idUsuario es el ID del usuario actual

            string nombreMedicamento = txtModificarMedicamento.Text;
            string laboratorio = txtModificacionLaboratorio.Text;
            string pautas = txtModificacionPautas.Text;
            string dosis = txtModificacionDosis.Text;
            string frecuencia = txtModificarFrecuencia.Text;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ModificarPrescripcion", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrescripcion", idPrescripcion);
                    cmd.Parameters.AddWithValue("@NombreMedicamento", nombreMedicamento);
                    cmd.Parameters.AddWithValue("@Laboratorio", laboratorio);
                    cmd.Parameters.AddWithValue("@Pautas", pautas);
                    cmd.Parameters.AddWithValue("@Dosis", dosis);
                    cmd.Parameters.AddWithValue("@Frecuencia", frecuencia);
                    cmd.Parameters.AddWithValue("@IdUsuarioModificacion", idUsuarioModificacion);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("La prescripción se ha modificado correctamente.");
            pnlModificacion.Visible = false;
            btnBuscar.PerformClick();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = false;
        }

        private void pnlModificacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int idResidente;
            if (!int.TryParse(txtIdResidente.Text, out idResidente))
            {
                MessageBox.Show("El ID del residente no es válido.");
                return;
            }

            string medicamento = cmbNombreMedicamento.SelectedItem as string;
            string laboratorio = txtLaboratorio.Text;
            string dosis = txtDosis.Text;
            string frecuencia = cmbFrecuencia.SelectedItem as string;
            string pautas = txtPautas.Text;

            int idUsuarioModificacion = _idUsuario; // Asegúrate de tener el ID del usuario actual

            // Llamada al procedimiento almacenado para guardar la prescripción
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AltaPrescripcion", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdResidente", idResidente);
                    cmd.Parameters.AddWithValue("@NombreMedicamento", medicamento);
                    cmd.Parameters.AddWithValue("@Laboratorio", laboratorio);
                    cmd.Parameters.AddWithValue("@Pautas", pautas);
                    cmd.Parameters.AddWithValue("@Dosis", dosis);
                    cmd.Parameters.AddWithValue("@Frecuencia", frecuencia);
                    cmd.Parameters.AddWithValue("@IdUsuarioModificacion", idUsuarioModificacion);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Cerrar el panel después de guardar
            pnlAddPrescripcion.Visible = false;

            // Mostrar confirmación
            MessageBox.Show("Prescripción guardada con éxito.");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            pnlAddPrescripcion.Visible = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (_idRol != 1) 
            {
                MessageBox.Show("No tienes permisos para modificar prescripciones.");
                return;
            }

            if (dgvPrescripciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una prescripción para modificar.");
                return;
            }

            int idPrescripcion = Convert.ToInt32(dgvPrescripciones.CurrentRow.Cells["IdPrescripcion"].Value);

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerPrescripcionPorId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrescripcion", idPrescripcion);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asignar los valores a los TextBox
                            txtModificacionLaboratorio.Text = reader["Laboratorio"].ToString();
                            txtModificacionPautas.Text = reader["Pautas"].ToString();
                            txtModificacionDosis.Text = reader["Dosis"].ToString();


                            txtModificarMedicamento.Text = reader["NombreMedicamento"].ToString();
                            txtModificarFrecuencia.Text = reader["Frecuencia"].ToString();
                        }
                    }
                }
            }

            // Mostrar el panel de modificación
            pnlModificacion.Visible = true;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (_idRol != 1) // 1 = Supervisor
            {
                MessageBox.Show("No tienes permisos para borrar prescripciones.");
                return;
            }

            if (dgvPrescripciones.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una prescripción para borrar.");
                return;
            }

            int idPrescripcion = Convert.ToInt32(dgvPrescripciones.CurrentRow.Cells["IdPrescripcion"].Value);

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_BorrarPrescripcion", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrescripcion", idPrescripcion);
                    cmd.Parameters.AddWithValue("@IdUsuarioModificacion", _idUsuario);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Prescripción borrada correctamente.");

            // Actualizar el DataGridView
            btnBuscar.PerformClick();
        }
    }
}
