namespace SalasEmpresa
{
    public partial class Inicio : Form
    {

        String[] listaCredenciales;
        String[] salas = { "Sala 1", "Sala 2", "Comedor" };
        Dictionary<string, string[]> horasPorSala = new Dictionary<string, string[]>(){
    { "Sala 1", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" } },
    { "Sala 2", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" } },
    { "Comedor", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "16:00" } } // Comedor no reservable 13-16
};

        public Inicio()
        {
            InitializeComponent();

            string credenciales = Properties.Resources.credenciales.ToString();
            listaCredenciales = credenciales.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {

            bool encontrado = false;
            for (int i = 0; i < listaCredenciales.Length; i += 2)
            {
                if (txtIdentificacion.Text == listaCredenciales[i] && txtContraseña.Text == listaCredenciales[i + 1])
                {
                    panel2.Visible = true;  // Mostrar panel de reserva
                    panel1.Visible = false; // Ocultar panel de login
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarSalas();
            CargarHoras();
        }

        private void CargarSalas()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                cmbSala.Items.Add(salas[i]);
            }
        }

        private void CargarHoras()
        {
            string salaSeleccionada = cmbSala.SelectedItem.ToString();

            cmbHora.Items.Clear(); 

            if (horasPorSala.ContainsKey(salaSeleccionada))
            {
                cmbHora.Items.AddRange(horasPorSala[salaSeleccionada]);
                if (cmbHora.Items.Count > 0)
                    cmbHora.SelectedIndex = 0; // Selecciona la primera hora disponible
            }
        }
    }
}
