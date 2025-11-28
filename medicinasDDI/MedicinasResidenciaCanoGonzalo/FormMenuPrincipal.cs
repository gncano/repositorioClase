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
        }

        private void btnResidentes_Click_1(object sender, EventArgs e)
        {
            FormResidentes frm = new FormResidentes(_idUsuario, _idRol);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnPrescripciones_Click_1(object sender, EventArgs e)
        {
            FormPrescripciones frm = new FormPrescripciones(_idUsuario, _idRol);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }



        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
