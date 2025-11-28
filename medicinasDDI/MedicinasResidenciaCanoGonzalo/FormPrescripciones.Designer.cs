namespace MedicinasResidenciaCanoGonzalo
{
    partial class FormPrescripciones
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
            panel1 = new Panel();
            cmbEstado = new ComboBox();
            label2 = new Label();
            btnAddPrescipcion = new Button();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            dgvPrescripciones = new DataGridView();
            btnSalir = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            pnlAddPrescripcion = new Panel();
            txtPautas = new TextBox();
            label10 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbFrecuencia = new ComboBox();
            label9 = new Label();
            txtDosis = new TextBox();
            label7 = new Label();
            txtLaboratorio = new TextBox();
            label6 = new Label();
            cmbNombreMedicamento = new ComboBox();
            label5 = new Label();
            lblNombre = new Label();
            label4 = new Label();
            txtIdResidente = new TextBox();
            label3 = new Label();
            pnlModificacion = new Panel();
            txtModificarFrecuencia = new TextBox();
            txtModificarMedicamento = new TextBox();
            txtModificacionPautas = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            txtModificacionDosis = new TextBox();
            label12 = new Label();
            txtModificacionLaboratorio = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescripciones).BeginInit();
            pnlAddPrescripcion.SuspendLayout();
            pnlModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAddPrescipcion);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(326, 55);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(143, 23);
            cmbEstado.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 58);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 4;
            label2.Text = "Introduce el estado de la prescripción";
            // 
            // btnAddPrescipcion
            // 
            btnAddPrescipcion.Location = new Point(518, 58);
            btnAddPrescipcion.Name = "btnAddPrescipcion";
            btnAddPrescipcion.Size = new Size(134, 23);
            btnAddPrescipcion.TabIndex = 3;
            btnAddPrescipcion.Text = "Añadir prescripción";
            btnAddPrescipcion.UseVisualStyleBackColor = true;
            btnAddPrescipcion.Click += btnAddPrescipcion_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(518, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(326, 11);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(143, 23);
            txtBuscarNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 14);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce el nombre del residente";
            // 
            // dgvPrescripciones
            // 
            dgvPrescripciones.AllowUserToAddRows = false;
            dgvPrescripciones.AllowUserToDeleteRows = false;
            dgvPrescripciones.AllowUserToResizeColumns = false;
            dgvPrescripciones.AllowUserToResizeRows = false;
            dgvPrescripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescripciones.Location = new Point(30, 133);
            dgvPrescripciones.Name = "dgvPrescripciones";
            dgvPrescripciones.ReadOnly = true;
            dgvPrescripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescripciones.Size = new Size(730, 220);
            dgvPrescripciones.TabIndex = 2;
            dgvPrescripciones.CellClick += dgvPrescripciones_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(578, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(361, 389);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Enabled = false;
            btnBorrar.Location = new Point(111, 389);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(119, 23);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar prescripción";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pnlAddPrescripcion
            // 
            pnlAddPrescripcion.BackColor = SystemColors.ActiveCaption;
            pnlAddPrescripcion.Controls.Add(txtPautas);
            pnlAddPrescripcion.Controls.Add(label10);
            pnlAddPrescripcion.Controls.Add(btnCancelar);
            pnlAddPrescripcion.Controls.Add(btnGuardar);
            pnlAddPrescripcion.Controls.Add(cmbFrecuencia);
            pnlAddPrescripcion.Controls.Add(label9);
            pnlAddPrescripcion.Controls.Add(txtDosis);
            pnlAddPrescripcion.Controls.Add(label7);
            pnlAddPrescripcion.Controls.Add(txtLaboratorio);
            pnlAddPrescripcion.Controls.Add(label6);
            pnlAddPrescripcion.Controls.Add(cmbNombreMedicamento);
            pnlAddPrescripcion.Controls.Add(label5);
            pnlAddPrescripcion.Controls.Add(lblNombre);
            pnlAddPrescripcion.Controls.Add(label4);
            pnlAddPrescripcion.Controls.Add(txtIdResidente);
            pnlAddPrescripcion.Controls.Add(label3);
            pnlAddPrescripcion.Location = new Point(12, 147);
            pnlAddPrescripcion.Name = "pnlAddPrescripcion";
            pnlAddPrescripcion.Size = new Size(777, 236);
            pnlAddPrescripcion.TabIndex = 12;
            pnlAddPrescripcion.Visible = false;
            // 
            // txtPautas
            // 
            txtPautas.Location = new Point(171, 137);
            txtPautas.Name = "txtPautas";
            txtPautas.Size = new Size(100, 23);
            txtPautas.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(97, 143);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 16;
            label10.Text = "Pautas";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(518, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(518, 106);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbFrecuencia
            // 
            cmbFrecuencia.FormattingEnabled = true;
            cmbFrecuencia.Location = new Point(171, 200);
            cmbFrecuencia.Name = "cmbFrecuencia";
            cmbFrecuencia.Size = new Size(121, 23);
            cmbFrecuencia.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(97, 203);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 12;
            label9.Text = "Frecuencia";
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(171, 166);
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new Size(100, 23);
            txtDosis.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 172);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 8;
            label7.Text = "Dosis";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(171, 108);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 114);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 6;
            label6.Text = "Laboratorio";
            // 
            // cmbNombreMedicamento
            // 
            cmbNombreMedicamento.FormattingEnabled = true;
            cmbNombreMedicamento.Location = new Point(171, 72);
            cmbNombreMedicamento.Name = "cmbNombreMedicamento";
            cmbNombreMedicamento.Size = new Size(121, 23);
            cmbNombreMedicamento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 75);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre del medicamento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(387, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 23);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Nombre";
            // 
            // txtIdResidente
            // 
            txtIdResidente.Location = new Point(171, 20);
            txtIdResidente.Name = "txtIdResidente";
            txtIdResidente.Size = new Size(100, 23);
            txtIdResidente.TabIndex = 1;
            txtIdResidente.TextChanged += txtIdResidente_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 20);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "Id del residente";
            // 
            // pnlModificacion
            // 
            pnlModificacion.BackColor = SystemColors.ActiveCaption;
            pnlModificacion.Controls.Add(txtModificarFrecuencia);
            pnlModificacion.Controls.Add(txtModificarMedicamento);
            pnlModificacion.Controls.Add(txtModificacionPautas);
            pnlModificacion.Controls.Add(label8);
            pnlModificacion.Controls.Add(button1);
            pnlModificacion.Controls.Add(button2);
            pnlModificacion.Controls.Add(label11);
            pnlModificacion.Controls.Add(txtModificacionDosis);
            pnlModificacion.Controls.Add(label12);
            pnlModificacion.Controls.Add(txtModificacionLaboratorio);
            pnlModificacion.Controls.Add(label13);
            pnlModificacion.Controls.Add(label14);
            pnlModificacion.Location = new Point(30, 133);
            pnlModificacion.Name = "pnlModificacion";
            pnlModificacion.Size = new Size(739, 237);
            pnlModificacion.TabIndex = 18;
            pnlModificacion.Visible = false;
            // 
            // txtModificarFrecuencia
            // 
            txtModificarFrecuencia.Location = new Point(226, 168);
            txtModificarFrecuencia.Name = "txtModificarFrecuencia";
            txtModificarFrecuencia.Size = new Size(100, 23);
            txtModificarFrecuencia.TabIndex = 21;
            // 
            // txtModificarMedicamento
            // 
            txtModificarMedicamento.Location = new Point(226, 40);
            txtModificarMedicamento.Name = "txtModificarMedicamento";
            txtModificarMedicamento.Size = new Size(100, 23);
            txtModificarMedicamento.TabIndex = 20;
            // 
            // txtModificacionPautas
            // 
            txtModificacionPautas.Location = new Point(226, 105);
            txtModificacionPautas.Name = "txtModificacionPautas";
            txtModificacionPautas.Size = new Size(100, 23);
            txtModificacionPautas.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 111);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 16;
            label8.Text = "Pautas";
            // 
            // button1
            // 
            button1.Location = new Point(474, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(474, 78);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(152, 171);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 12;
            label11.Text = "Frecuencia";
            // 
            // txtModificacionDosis
            // 
            txtModificacionDosis.Location = new Point(226, 134);
            txtModificacionDosis.Name = "txtModificacionDosis";
            txtModificacionDosis.Size = new Size(100, 23);
            txtModificacionDosis.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(152, 140);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 8;
            label12.Text = "Dosis";
            // 
            // txtModificacionLaboratorio
            // 
            txtModificacionLaboratorio.Location = new Point(226, 76);
            txtModificacionLaboratorio.Name = "txtModificacionLaboratorio";
            txtModificacionLaboratorio.Size = new Size(100, 23);
            txtModificacionLaboratorio.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(152, 82);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 6;
            label13.Text = "Laboratorio";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(73, 43);
            label14.Name = "label14";
            label14.Size = new Size(147, 15);
            label14.TabIndex = 4;
            label14.Text = "Nombre del medicamento";
            // 
            // FormPrescripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlModificacion);
            Controls.Add(pnlAddPrescripcion);
            Controls.Add(btnSalir);
            Controls.Add(dgvPrescripciones);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(panel1);
            Name = "FormPrescripciones";
            Text = "FormPrescripciones";
            Load += FormPrescripciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescripciones).EndInit();
            pnlAddPrescripcion.ResumeLayout(false);
            pnlAddPrescripcion.PerformLayout();
            pnlModificacion.ResumeLayout(false);
            pnlModificacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddPrescipcion;
        private Button btnBuscar;
        private TextBox txtBuscarNombre;
        private Label label1;
        private ComboBox cmbEstado;
        private Label label2;
        private DataGridView dgvPrescripciones;
        private Button btnSalir;
        private Button btnModificar;
        private Button btnBorrar;
        private Panel pnlAddPrescripcion;
        private Label label3;
        private Label label4;
        private TextBox txtIdResidente;
        private Label lblNombre;
        private Label label5;
        private Label label6;
        private ComboBox cmbNombreMedicamento;
        private TextBox txtLaboratorio;
        private ComboBox cmbFrecuencia;
        private Label label9;
        private TextBox txtDosis;
        private Label label7;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtPautas;
        private Label label10;
        private Panel pnlModificacion;
        private TextBox txtModificacionPautas;
        private Label label8;
        private Button button1;
        private Button button2;
        private Label label11;
        private TextBox txtModificacionDosis;
        private Label label12;
        private TextBox txtModificacionLaboratorio;
        private Label label13;
        private Label label14;
        private TextBox txtModificarFrecuencia;
        private TextBox txtModificarMedicamento;
    }
}