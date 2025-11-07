using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "valor";
            cmbEstado.SelectedIndex = 0;
            txtId.Text = "0";

            List<Rol> listaRol = new CN_Rol().CNListar();

            foreach (Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionCombo() { valor = item.IdRol, Texto = item.Descripcion });
            }

            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "valor";
            cmbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && !(columna is DataGridViewColumn))
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { valor = columna.Index, Texto = columna.HeaderText });
                }
            }

            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[]
            {
                "",
                txtId.Text,
                txtUsuario.Text,
                txtNombre,
                txtCorreo,
                txtContraseña,

                ((OpcionCombo)cmbRol.SelectedItem).valor.ToString(),
                ((OpcionCombo)cmbRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cmbEstado.SelectedItem).valor.ToString(),
                ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString(),
            }
                );

            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConfirmar.Text = "";
            cmbRol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            txtUsuario.Select();
        }
    }
}
