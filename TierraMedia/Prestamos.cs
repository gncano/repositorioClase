namespace TierraMedia
{
    public partial class Prestamos : Form
    {
        String[] lugares_disponibles;
        string[] razas_disponibles = {
                "Balrog", "Dunedain", "Enano",
                "Elfo", "Ent", "Goblin",
                "Hobbit", "Hombre", "Istari (Mago)",
                "Orco", "Troll", "Uruk-hai" };
        String nombre_cliente;
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 180, 240 };
        Dictionary<int, double> intereses_base;
        public Prestamos(String nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;
            string listado_ciudades = Properties.Resources.Lugares.ToString();
            lugares_disponibles = listado_ciudades.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            intereses_base = new Dictionary<int, double>();
            int i;
            double intereses;
            for (i = 0, intereses = 3.0; i < cuotas_disponibles.Length; i++, intereses += 0.5)
            {
                intereses_base[cuotas_disponibles[i]] = intereses;
            }



        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            lblSaludo.Text += nombre_cliente;
            visualizarRazas();
            visualizarCiudades();
            visualizarCuotas();
        }

        private void visualizarCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cmbCuotas.Items.Add(cuotas_disponibles[i]);
            }
        }

        private void visualizarCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                cmbLugar.Items.Add(lugares_disponibles[i]);
            }
        }

        private void visualizarRazas()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                cmbRaza.Items.Add(razas_disponibles[i]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.Clear();
                        errorProvider2.Clear();
                        double interes_mensual = calcularInteres();
                        double importe_pedido = double.Parse(txtbPrestamo.Text);
                        int cuotas_pedidas = (int)cmbCuotas.SelectedItem;
                        double interes_total = importe_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double importe_devolver = importe_pedido + interes_total;
                        String mensaje = "Su prestamo de " + importe_pedido + " en " + cuotas_pedidas +
                            " meses se concedera con un interes del " + interes_mensual
                            + "% mensual. \n El importe final a devolver es de " + importe_devolver;

                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Calculo de interes", botones);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(panel1, "Debes indicar un lugar y una raza");
                        errorProvider2.Clear();
                        break;
                    }
                case 2:
                    {
                        errorProvider1.Clear();
                        errorProvider2.SetError(panel2,"Debes indicar un préstamo numérico y el numero de cuotas");
                        break;
                    }
            }

        }

        double calcularInteres()
        {
            int cuotas_pedidas = (int)cmbCuotas.SelectedItem;
            double interes = intereses_base[cuotas_pedidas];
            string raza_seleccionada = cmbRaza.SelectedItem.ToString().ToLower();
            String lugar_seleccionado = cmbLugar.SelectedItem.ToString().ToLower();
            if (new[] { "orco", "uruk-hai", "goblin", "troll", "balrog" }.Contains(raza_seleccionada))
            {
                interes += 0.3;

            }
            if (new[] { "rivendel", "tirion", "valinor", "hobbiton", "bree", "gondor" }.Contains(lugar_seleccionado))
            {
                interes -= 0.3;
            }
            return interes;

        }

        int validaciones()
        {
            if (cmbRaza.SelectedIndex == -1 || cmbLugar.SelectedIndex == -1)
            {
                return 1;
            }
            else
            {
                if (!(txtbPrestamo.Text.All(Char.IsAsciiDigit)) || (cmbCuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }


        }

    }
}
