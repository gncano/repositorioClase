namespace SalasEmpresa
{
    public partial class Inicio : Form
    {

        String[] listaCredenciales;
        public Inicio()
        {
            InitializeComponent();

            string credenciales = Properties.Resources.credenciales.ToString();
            listaCredenciales = credenciales.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i = 0;
            while ( i < listaCredenciales.Length) {
                if (txtIdentificacion.Text == listaCredenciales[i])
                {
                    if(txtContraseña.Text == listaCredenciales[i + 1])
                    {
                        panel2.Visible = true;
                        panel1.Visible = false;
                        break;
                    }
                }

                i++;
            }
        }
    }
}
