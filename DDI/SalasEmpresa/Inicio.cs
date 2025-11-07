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

        Dictionary<string, string[]> reservas = new Dictionary<string, string[]>()
{
            { "Sala 1", new string[9] },
            { "Sala 2", new string[9] },
            { "Comedor", new string[9] }};

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
            string salaSeleccionada = cmbSala.SelectedItem.ToString(); //error preguntar a Rosa

            cmbHora.Items.Clear();

            if (horasPorSala.ContainsKey(salaSeleccionada))
            {
                cmbHora.Items.AddRange(horasPorSala[salaSeleccionada]);
                if (cmbHora.Items.Count > 0)
                    cmbHora.SelectedIndex = 0; 
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
            string usuario = txtIdentificacion.Text;
            string sala = cmbSala.SelectedItem?.ToString();
            int horaIndice = cmbHora.SelectedIndex;

            int numeroAsistentes = 0;


            if (sala == null || horaIndice < 0)
            {
                MessageBox.Show("Selecciona una sala y una hora.");
                return;
            }

            if (!ValidarAsistentes())
            {
                return;

            }
            else
            {
                numeroAsistentes = int.Parse(txtNumAsistentes.Text.Trim());
            }

                int capacidadMax = 0;
            switch (sala)
            {
                case "Sala 1": capacidadMax = 8; break;
                case "Sala 2": capacidadMax = 10; break;
                case "Comedor": capacidadMax = 20; break;
            }

            if (numeroAsistentes > capacidadMax)
            {
                MessageBox.Show("El número de asistentes excede la capacidad máxima de {capacidadMax}.");
                return;
            }

            if (!ValidarRefrigerio())
                return;

            if (!HoraDisponible(sala, horaIndice))
            {
                MessageBox.Show("La hora seleccionada ya está reservada.");
                return;
            }

            ReservarHora(usuario, sala, horaIndice);

            ActualizarHoras();

            string mensaje = $"Reserva realizada:\nSala: {sala}\nHora: {cmbHora.SelectedItem}\nAsistentes: {numeroAsistentes}";

            if (!string.IsNullOrEmpty(cmbBebida.Text) || !string.IsNullOrEmpty(cmbBocadito.Text))
                mensaje += $"\nRefrigerio: {cmbBebida.Text} y {cmbBocadito.Text}";

            MessageBox.Show(mensaje, "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNumAsistentes.Clear();
            cmbBebida.SelectedIndex = -1;
            cmbBocadito.SelectedIndex = -1;

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

        private bool HoraDisponible(string sala, int horaPos)
        {
            return reservas[sala][horaPos] == null;
        }

        private void ReservarHora(string usuario, string sala, int horaPos)
        {
            reservas[sala][horaPos] = usuario;
        }
        private void ActualizarHoras()
        {
            cmbHora.Items.Clear();
            string[] horas = { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" };
            string salaSeleccionada = cmbSala.SelectedItem?.ToString(); // uso ? para evitar errores si es null

            for (int i = 0; i < horas.Length; i++)
            {
                if (salaSeleccionada == "Comedor" && i >= 5 && i <= 7)
                {
                    continue;
                }

                cmbHora.Items.Add(horas[i]);
            }

            if (cmbHora.Items.Count > 0)
                cmbHora.SelectedIndex = 0;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

            txtIdentificacion.Clear();
            txtContraseña.Clear();
            txtNumAsistentes.Clear();
            cmbSala.Items.Clear();
            cmbSala.SelectedIndex = -1;
            cmbHora.Items.Clear();
            cmbBebida.SelectedIndex = -1;
            cmbBocadito.SelectedIndex = -1;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
