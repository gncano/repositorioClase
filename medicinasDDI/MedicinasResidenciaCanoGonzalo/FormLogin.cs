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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            string alias = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, introduce usuario y clave.");
                return;
            }

            try
            {
              
                string cnn = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cnn))
                using (SqlCommand cmd = new SqlCommand("sp_LoginUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Alias", alias);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    con.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            // Usuario correcto
                            int idUsuario = Convert.ToInt32(rdr["IdUsuario"]);
                            int idRol = Convert.ToInt32(rdr["IdRol"]);
                            string nombre = rdr["Nombre"].ToString();

                            // Abrir menú principal y pasar datos
                            this.Hide();
                            FormMenuPrincipal menu = new FormMenuPrincipal(idUsuario, idRol, nombre);
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o clave incorrectos, o usuario inactivo.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
