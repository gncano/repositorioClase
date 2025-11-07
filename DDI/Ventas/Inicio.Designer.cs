namespace Ventas
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            mnuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            mnuAdmin = new FontAwesome.Sharp.IconMenuItem();
            submnuCategoria = new ToolStripMenuItem();
            submnuProducto = new ToolStripMenuItem();
            mnuVentas = new FontAwesome.Sharp.IconMenuItem();
            submnuRegistrarVenta = new ToolStripMenuItem();
            submnuVerDetalleVenta = new ToolStripMenuItem();
            mnuCompras = new FontAwesome.Sharp.IconMenuItem();
            submnuRegistraCompra = new ToolStripMenuItem();
            submnuVerDetalleCompra = new ToolStripMenuItem();
            mnuClientes = new FontAwesome.Sharp.IconMenuItem();
            mnuProveedores = new FontAwesome.Sharp.IconMenuItem();
            mnuInformes = new FontAwesome.Sharp.IconMenuItem();
            mnuAcercade = new FontAwesome.Sharp.IconMenuItem();
            mnuTitulo = new MenuStrip();
            label2 = new Label();
            lblUsuario = new Label();
            contenedor = new Panel();
            label1 = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { mnuUsuarios, mnuAdmin, mnuVentas, mnuCompras, mnuClientes, mnuProveedores, mnuInformes, mnuAcercade });
            menu.Location = new Point(0, 43);
            menu.Name = "menu";
            menu.Size = new Size(1046, 73);
            menu.TabIndex = 2;
            menu.Text = "menuStrip2";
            // 
            // mnuUsuarios
            // 
            mnuUsuarios.AutoSize = false;
            mnuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            mnuUsuarios.IconColor = Color.Black;
            mnuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuUsuarios.IconSize = 50;
            mnuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            mnuUsuarios.Name = "mnuUsuarios";
            mnuUsuarios.Size = new Size(64, 69);
            mnuUsuarios.Text = "Usuario";
            mnuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            mnuUsuarios.Click += mnuUsuarios_Click;
            // 
            // mnuAdmin
            // 
            mnuAdmin.AutoSize = false;
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { submnuCategoria, submnuProducto });
            mnuAdmin.IconChar = FontAwesome.Sharp.IconChar.Compass;
            mnuAdmin.IconColor = Color.Black;
            mnuAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuAdmin.IconSize = 50;
            mnuAdmin.ImageScaling = ToolStripItemImageScaling.None;
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(64, 69);
            mnuAdmin.Text = "Admin";
            mnuAdmin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submnuCategoria
            // 
            submnuCategoria.Name = "submnuCategoria";
            submnuCategoria.Size = new Size(180, 22);
            submnuCategoria.Text = "Categoría";
            submnuCategoria.Click += submnuCategoria_Click;
            // 
            // submnuProducto
            // 
            submnuProducto.Alignment = ToolStripItemAlignment.Right;
            submnuProducto.Name = "submnuProducto";
            submnuProducto.Size = new Size(180, 22);
            submnuProducto.Text = "Producto";
            submnuProducto.Click += submnuProducto_Click;
            // 
            // mnuVentas
            // 
            mnuVentas.AutoSize = false;
            mnuVentas.DropDownItems.AddRange(new ToolStripItem[] { submnuRegistrarVenta, submnuVerDetalleVenta });
            mnuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            mnuVentas.IconColor = Color.Black;
            mnuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuVentas.IconSize = 50;
            mnuVentas.ImageScaling = ToolStripItemImageScaling.None;
            mnuVentas.Name = "mnuVentas";
            mnuVentas.Size = new Size(64, 69);
            mnuVentas.Text = "Ventas";
            mnuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submnuRegistrarVenta
            // 
            submnuRegistrarVenta.Name = "submnuRegistrarVenta";
            submnuRegistrarVenta.Size = new Size(152, 22);
            submnuRegistrarVenta.Text = "Registrar venta";
            submnuRegistrarVenta.Click += submnuRegistrarVenta_Click;
            // 
            // submnuVerDetalleVenta
            // 
            submnuVerDetalleVenta.Name = "submnuVerDetalleVenta";
            submnuVerDetalleVenta.Size = new Size(152, 22);
            submnuVerDetalleVenta.Text = "Ver detalle";
            submnuVerDetalleVenta.Click += submnuVerDetalleVenta_Click;
            // 
            // mnuCompras
            // 
            mnuCompras.AutoSize = false;
            mnuCompras.DropDownItems.AddRange(new ToolStripItem[] { submnuRegistraCompra, submnuVerDetalleCompra });
            mnuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            mnuCompras.IconColor = Color.Black;
            mnuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuCompras.IconSize = 50;
            mnuCompras.ImageScaling = ToolStripItemImageScaling.None;
            mnuCompras.Name = "mnuCompras";
            mnuCompras.Size = new Size(64, 69);
            mnuCompras.Text = "Compras";
            mnuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submnuRegistraCompra
            // 
            submnuRegistraCompra.Name = "submnuRegistraCompra";
            submnuRegistraCompra.Size = new Size(152, 22);
            submnuRegistraCompra.Text = "Nueva compra";
            submnuRegistraCompra.Click += submnuRegistraCompra_Click;
            // 
            // submnuVerDetalleCompra
            // 
            submnuVerDetalleCompra.Name = "submnuVerDetalleCompra";
            submnuVerDetalleCompra.Size = new Size(152, 22);
            submnuVerDetalleCompra.Text = "Ver detalle";
            submnuVerDetalleCompra.Click += submnuVerDetalleCompra_Click;
            // 
            // mnuClientes
            // 
            mnuClientes.AutoSize = false;
            mnuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            mnuClientes.IconColor = Color.Black;
            mnuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuClientes.IconSize = 50;
            mnuClientes.ImageScaling = ToolStripItemImageScaling.None;
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(64, 69);
            mnuClientes.Text = "Clientes";
            mnuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            mnuClientes.Click += mnuClientes_Click;
            // 
            // mnuProveedores
            // 
            mnuProveedores.AutoSize = false;
            mnuProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            mnuProveedores.IconColor = Color.Black;
            mnuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuProveedores.IconSize = 50;
            mnuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            mnuProveedores.Name = "mnuProveedores";
            mnuProveedores.Size = new Size(70, 69);
            mnuProveedores.Text = "Proveedores";
            mnuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            mnuProveedores.Click += mnuProveedores_Click;
            // 
            // mnuInformes
            // 
            mnuInformes.AutoSize = false;
            mnuInformes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            mnuInformes.IconColor = Color.Black;
            mnuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuInformes.IconSize = 50;
            mnuInformes.ImageScaling = ToolStripItemImageScaling.None;
            mnuInformes.Name = "mnuInformes";
            mnuInformes.Size = new Size(64, 69);
            mnuInformes.Text = "Informes";
            mnuInformes.TextImageRelation = TextImageRelation.ImageAboveText;
            mnuInformes.Click += mnuInformes_Click;
            // 
            // mnuAcercade
            // 
            mnuAcercade.AutoSize = false;
            mnuAcercade.IconChar = FontAwesome.Sharp.IconChar.Info;
            mnuAcercade.IconColor = Color.Black;
            mnuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mnuAcercade.IconSize = 50;
            mnuAcercade.ImageScaling = ToolStripItemImageScaling.None;
            mnuAcercade.Name = "mnuAcercade";
            mnuAcercade.Size = new Size(64, 69);
            mnuAcercade.Text = "Acerca de";
            mnuAcercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mnuTitulo
            // 
            mnuTitulo.AllowDrop = true;
            mnuTitulo.AutoSize = false;
            mnuTitulo.BackColor = Color.SteelBlue;
            mnuTitulo.Location = new Point(0, 0);
            mnuTitulo.Name = "mnuTitulo";
            mnuTitulo.RightToLeft = RightToLeft.Yes;
            mnuTitulo.Size = new Size(1046, 43);
            mnuTitulo.TabIndex = 1;
            mnuTitulo.Text = "menuStrip1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(900, 15);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.SteelBlue;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(965, 17);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(48, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "ADMIN";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 116);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1046, 420);
            contenedor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 2;
            label1.Text = "SISTEMA DE VENTAS";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 536);
            Controls.Add(contenedor);
            Controls.Add(lblUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(mnuTitulo);
            MainMenuStrip = mnuTitulo;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem mnuUsuarios;
        private MenuStrip mnuTitulo;
        private FontAwesome.Sharp.IconMenuItem mnuAdmin;
        private FontAwesome.Sharp.IconMenuItem mnuVentas;
        private FontAwesome.Sharp.IconMenuItem mnuCompras;
        private FontAwesome.Sharp.IconMenuItem mnuClientes;
        private FontAwesome.Sharp.IconMenuItem mnuProveedores;
        private FontAwesome.Sharp.IconMenuItem mnuInformes;
        private FontAwesome.Sharp.IconMenuItem mnuAcercade;
        private Label label2;
        private Label lblUsuario;
        private ToolStripMenuItem submnuCategoria;
        private ToolStripMenuItem submnuProducto;
        private Panel contenedor;
        private Label label1;
        private ToolStripMenuItem submnuRegistrarVenta;
        private ToolStripMenuItem submnuVerDetalleVenta;
        private ToolStripMenuItem submnuRegistraCompra;
        private ToolStripMenuItem submnuVerDetalleCompra;
    }
}
