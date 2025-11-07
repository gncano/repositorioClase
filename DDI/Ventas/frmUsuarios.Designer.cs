namespace CapaPresentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtIndice = new TextBox();
            txtId = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            label8 = new Label();
            cmbRol = new ComboBox();
            label7 = new Label();
            txtConfirmar = new TextBox();
            label6 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvData = new DataGridView();
            seleccionar = new DataGridViewButtonColumn();
            Usuario = new DataGridViewTextBoxColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            cmbBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtConfirmar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(77, 23);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(56, 23);
            txtIndice.TabIndex = 19;
            txtIndice.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(139, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(56, 23);
            txtId.TabIndex = 18;
            txtId.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 17;
            btnLimpiar.Location = new Point(22, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 17;
            btnEliminar.Location = new Point(22, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 17;
            btnGuardar.Location = new Point(22, 362);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(22, 332);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 312);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 13;
            label8.Text = "Estado";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(22, 286);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 266);
            label7.Name = "label7";
            label7.Size = new Size(27, 17);
            label7.TabIndex = 11;
            label7.Text = "Rol";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(22, 237);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(139, 23);
            txtConfirmar.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 215);
            label6.Name = "label6";
            label6.Size = new Size(134, 17);
            label6.TabIndex = 9;
            label6.Text = "Confirmar contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(20, 189);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(139, 23);
            txtContraseña.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 167);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 7;
            label5.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 141);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(139, 23);
            txtCorreo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 119);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 5;
            label4.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 71);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(20, 45);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(139, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Detalle Usuario";
            // 
            // dgvData
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { seleccionar, Usuario, idUsuario, NroDocumento, Nombre, Correo, Clave, idRol, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(206, 61);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(582, 377);
            dgvData.TabIndex = 1;
            // 
            // seleccionar
            // 
            seleccionar.HeaderText = " ";
            seleccionar.Name = "seleccionar";
            seleccionar.ReadOnly = true;
            seleccionar.Width = 20;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 58;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.ReadOnly = true;
            NroDocumento.Width = 75;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Completo";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 130;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 130;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 150;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 60;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 60;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(217, 11);
            label9.Name = "label9";
            label9.Size = new Size(571, 36);
            label9.TabIndex = 2;
            label9.Text = "Lista de Usuarios";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(490, 18);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(103, 23);
            cmbBusqueda.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(599, 18);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(76, 23);
            txtBusqueda.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 17;
            btnBuscar.Location = new Point(681, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(23, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.Black;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 17;
            btnLimpiarBuscador.Location = new Point(710, 18);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(23, 23);
            btnLimpiarBuscador.TabIndex = 6;
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.IconSize = 17;
            btnImprimir.Location = new Point(739, 17);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(23, 23);
            btnImprimir.TabIndex = 7;
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(414, 20);
            label10.Name = "label10";
            label10.Size = new Size(74, 17);
            label10.TabIndex = 20;
            label10.Text = "Buscar por:";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(btnImprimir);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cmbBusqueda);
            Controls.Add(label9);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtConfirmar;
        private Label label6;
        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private ComboBox cmbEstado;
        private Label label8;
        private ComboBox cmbRol;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtIndice;
        private TextBox txtId;
        private DataGridView dgvData;
        private Label label9;
        private DataGridViewButtonColumn seleccionar;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private ComboBox cmbBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private Label label10;
    }
}