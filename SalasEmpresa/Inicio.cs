namespace SalasEmpresa
{
    public partial class Inicio : Form
    {

        String[] listaCredenciales;
        String[] salas = { "Sala 1", "Sala 2", "Comedor" };
        Dictionary<string, string[]> horasPorSala = new Dictionary<string, string[]>(){
            { "Sala 1", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" } },
            { "Sala 2", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" } },
            { "Comedor", new string[] { "8:00", "9:00", "10:00", "11:00", "12:00", "16:00" } } };

        Dictionary<string, int> capacidadSalas = new Dictionary<string, int>(){
            { "Sala 1", 8 },
            { "Sala 2", 10 },
            { "Comedor", 20 }};

        Dictionary<string, double> bebidas = new Dictionary<string, double>(){
            { "Agua", 0.5 },
            { "Café y leche", 1.0 },
            { "Zumo de naranja", 1.5 }};

        Dictionary<string, double> bocaditos = new Dictionary<string, double>()
{
            { "Cruasán", 1.0 },
            { "Jamón", 1.5 },
            { "Vegetal", 2.0 }
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

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHoras();
        }

        private bool ValidarAsistentes()
        {
            int numeroAsistentes;


            if (!int.TryParse(txtNumAsistentes.Text.Trim(), out numeroAsistentes))
            // el out devuelve true si la conversión ha sido exitosa, preguntar a Rosa
            {
                MessageBox.Show("Introduce un número válido de asistentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string salaSeleccionada = cmbSala.SelectedItem.ToString();


            if (numeroAsistentes < 1 || numeroAsistentes > capacidadSalas[salaSeleccionada])
            {
                MessageBox.Show($"La {salaSeleccionada} admite entre 1 y {capacidadSalas[salaSeleccionada]} personas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ValidarAsistentes();
            ValidarRefrigerio();

        }

        private void ckbRefrigerio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRefrigerio.Checked)
            {
                panel3.Visible = true;
                CargarRefrigerios();
            }
            else
            {
                panel3.Visible = false;
            }

        }

        private void CargarRefrigerios()
        {
            // Limpiar y agregar opción vacía (ninguno)
            cmbBebida.Items.Clear();
            cmbBebida.Items.Add("");
            cmbBebida.Items.AddRange(bebidas.Keys.ToArray());
            cmbBebida.SelectedIndex = 0;

            cmbBocadito.Items.Clear();
            cmbBocadito.Items.Add("");
            cmbBocadito.Items.AddRange(bocaditos.Keys.ToArray());
            cmbBocadito.SelectedIndex = 0;
        }

        private bool ValidarRefrigerio()
        {

            double precioBebida = 0;
            double precioBocadito = 0;

            if (!string.IsNullOrEmpty(cmbBebida.SelectedItem?.ToString()))
                precioBebida = bebidas[cmbBebida.SelectedItem.ToString()];

            if (!string.IsNullOrEmpty(cmbBocadito.SelectedItem?.ToString()))
                precioBocadito = bocaditos[cmbBocadito.SelectedItem.ToString()];

            double costePorPersona = precioBebida + precioBocadito;

            if (costePorPersona > 2.5)
            {
                MessageBox.Show("El coste del refrigerio no puede superar 2,5€ por persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
