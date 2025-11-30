namespace MedicinasResidenciaCanoGonzalo
{
    partial class FormResidentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResidentes));
            panel1 = new Panel();
            btnAlta = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            dgvResidentes = new DataGridView();
            pnlModificar = new Panel();
            btnAcceptar = new Button();
            txtHabitacion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlAlta = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnAltaAceptar = new FontAwesome.Sharp.IconButton();
            txtAltaHabitacion = new TextBox();
            txtAltaApellido = new TextBox();
            txtAltaNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnBaja = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
            pnlModificar.SuspendLayout();
            pnlAlta.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAlta);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 0;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.MediumSeaGreen;
            btnAlta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAlta.IconColor = Color.Black;
            btnAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlta.IconSize = 20;
            btnAlta.Location = new Point(518, 58);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(118, 31);
            btnAlta.TabIndex = 10;
            btnAlta.Text = "Dar de Alta";
            btnAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumSeaGreen;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.LongArrowRight;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(518, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 31);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(252, 11);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(217, 23);
            txtBuscarNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 14);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce el nombre del residente";
            // 
            // dgvResidentes
            // 
            dgvResidentes.AllowUserToAddRows = false;
            dgvResidentes.AllowUserToDeleteRows = false;
            dgvResidentes.AllowUserToResizeColumns = false;
            dgvResidentes.AllowUserToResizeRows = false;
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Location = new Point(28, 150);
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.ReadOnly = true;
            dgvResidentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidentes.Size = new Size(730, 220);
            dgvResidentes.TabIndex = 1;
            dgvResidentes.CellClick += dgvResidentes_CellClick;
            // 
            // pnlModificar
            // 
            pnlModificar.Controls.Add(btnAcceptar);
            pnlModificar.Controls.Add(txtHabitacion);
            pnlModificar.Controls.Add(txtApellido);
            pnlModificar.Controls.Add(txtNombre);
            pnlModificar.Controls.Add(label4);
            pnlModificar.Controls.Add(label3);
            pnlModificar.Controls.Add(label2);
            pnlModificar.Location = new Point(9, 161);
            pnlModificar.Name = "pnlModificar";
            pnlModificar.Size = new Size(779, 161);
            pnlModificar.TabIndex = 6;
            pnlModificar.Visible = false;
            // 
            // btnAcceptar
            // 
            btnAcceptar.Location = new Point(621, 66);
            btnAcceptar.Name = "btnAcceptar";
            btnAcceptar.Size = new Size(75, 23);
            btnAcceptar.TabIndex = 6;
            btnAcceptar.Text = "ACEPTAR";
            btnAcceptar.UseVisualStyleBackColor = true;
            btnAcceptar.Click += btnAcceptar_Click;
            // 
            // txtHabitacion
            // 
            txtHabitacion.Location = new Point(435, 83);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new Size(100, 23);
            txtHabitacion.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 26);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 2;
            label4.Text = "Numero de habitación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 26);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 26);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // pnlAlta
            // 
            pnlAlta.BackColor = Color.Khaki;
            pnlAlta.Controls.Add(btnCancelar);
            pnlAlta.Controls.Add(btnAltaAceptar);
            pnlAlta.Controls.Add(txtAltaHabitacion);
            pnlAlta.Controls.Add(txtAltaApellido);
            pnlAlta.Controls.Add(txtAltaNombre);
            pnlAlta.Controls.Add(label5);
            pnlAlta.Controls.Add(label6);
            pnlAlta.Controls.Add(label7);
            pnlAlta.Location = new Point(9, 161);
            pnlAlta.Name = "pnlAlta";
            pnlAlta.Size = new Size(779, 161);
            pnlAlta.TabIndex = 7;
            pnlAlta.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MediumSeaGreen;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 20;
            btnCancelar.Location = new Point(592, 108);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAltaAceptar
            // 
            btnAltaAceptar.BackColor = Color.MediumSeaGreen;
            btnAltaAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaAceptar.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            btnAltaAceptar.IconColor = Color.Black;
            btnAltaAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAltaAceptar.IconSize = 20;
            btnAltaAceptar.Location = new Point(592, 61);
            btnAltaAceptar.Name = "btnAltaAceptar";
            btnAltaAceptar.Size = new Size(118, 31);
            btnAltaAceptar.TabIndex = 11;
            btnAltaAceptar.Text = "Aceptar";
            btnAltaAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAltaAceptar.UseVisualStyleBackColor = false;
            btnAltaAceptar.Click += btnAltaAceptar_Click_1;
            // 
            // txtAltaHabitacion
            // 
            txtAltaHabitacion.Location = new Point(435, 83);
            txtAltaHabitacion.Name = "txtAltaHabitacion";
            txtAltaHabitacion.Size = new Size(100, 23);
            txtAltaHabitacion.TabIndex = 5;
            // 
            // txtAltaApellido
            // 
            txtAltaApellido.Location = new Point(235, 83);
            txtAltaApellido.Name = "txtAltaApellido";
            txtAltaApellido.Size = new Size(100, 23);
            txtAltaApellido.TabIndex = 4;
            // 
            // txtAltaNombre
            // 
            txtAltaNombre.Location = new Point(57, 83);
            txtAltaNombre.Name = "txtAltaNombre";
            txtAltaNombre.Size = new Size(100, 23);
            txtAltaNombre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 26);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 2;
            label5.Text = "Numero de habitación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 26);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 1;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 26);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 0;
            label7.Text = "Nombre";
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.MediumSeaGreen;
            btnBaja.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnBaja.IconColor = Color.Black;
            btnBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBaja.IconSize = 20;
            btnBaja.Location = new Point(121, 388);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(118, 31);
            btnBaja.TabIndex = 12;
            btnBaja.Text = "Dar de Baja";
            btnBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.MediumSeaGreen;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Modx;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 20;
            btnModificar.Location = new Point(345, 388);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 31);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MediumSeaGreen;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 20;
            btnSalir.Location = new Point(567, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 31);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // FormResidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(pnlAlta);
            Controls.Add(pnlModificar);
            Controls.Add(dgvResidentes);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormResidentes";
            Text = "FormResidentes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            pnlModificar.ResumeLayout(false);
            pnlModificar.PerformLayout();
            pnlAlta.ResumeLayout(false);
            pnlAlta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscarNombre;
        private Label label1;
        private DataGridView dgvResidentes;
        private Panel pnlModificar;
        private Label label2;
        private TextBox txtHabitacion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Button btnAcceptar;
        private Panel pnlAlta;
        private TextBox txtAltaHabitacion;
        private TextBox txtAltaApellido;
        private TextBox txtAltaNombre;
        private Label label5;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnAlta;
        private FontAwesome.Sharp.IconButton btnAltaAceptar;
        private FontAwesome.Sharp.IconButton btnBaja;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}