using CapaNegocio;
using CapaEntidad;
using CapaPresentacion;
using FontAwesome.Sharp;

namespace Ventas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreUsuario;
        }



        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            //contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submnuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuAdmin, new frmCategoria());
        }

        private void submnuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuAdmin, new frmProducto());
        }

        private void submnuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuVentas, new frmVentas());
        }

        private void submnuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuVentas, new frmDetalleVenta());
        }

        private void submnuRegistraCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuCompras, new frmCompras());
        }

        private void submnuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(mnuCompras, new frmDetalleCompra());
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void mnuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void mnuInformes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmInformes());
        }
    }
}
