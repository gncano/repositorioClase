namespace MedicinasResidenciaCanoGonzalo
{


    public partial class FormMenuPrincipal : Form
    {
        private int _idUsuario;
        private int _idRol;
        private string _nombre;
        public FormMenuPrincipal(int idUsuario, int idRol, string nombre)
        {
            InitializeComponent();

            _idUsuario = idUsuario;
            _idRol = idRol;
            _nombre = nombre;

            lblBienvenido.Text = $"Bienvenido, {_nombre}";


            if (_idRol != 1)
            {
                btnResidentes.Enabled = false;
                btnPrescripciones.Enabled = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnResidentes_Click(object sender, EventArgs e)
        {
            FormResidentes frm = new FormResidentes(_idUsuario, _idRol);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnPrescripciones_Click(object sender, EventArgs e)
        {
            // frm = new FormPrescripciones(_idUsuario, _idRol);
            //frm.ShowDialog();
        }
    }
}
