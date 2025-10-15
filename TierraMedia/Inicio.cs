namespace TierraMedia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSolicitar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }


        private void ControlBotones()
        {
            if (txtNombre.Text.Trim() != String.Empty && txtNombre.Text.All(char.IsLetter))
            {
                btnSolicitar.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                if (!txtNombre.Text.All(char.IsLetter))
                {
                    errorProvider1.SetError(txtNombre, "El nombre solo puede contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "El nombre es un campo obligatorio");
                }
                btnSolicitar.Enabled = false;
                txtNombre.Focus();
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Prestamos ventanaPrestamos = new Prestamos(txtNombre.Text);
            ventanaPrestamos.ShowDialog();
        }
    }
}
