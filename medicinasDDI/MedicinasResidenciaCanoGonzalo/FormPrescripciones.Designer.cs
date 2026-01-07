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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrescripciones));
            panel1 = new Panel();
            btnAddPrescipcion = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            label2 = new Label();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            pnlModificacion = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtModificarFrecuencia = new TextBox();
            txtModificarMedicamento = new TextBox();
            txtModificacionPautas = new TextBox();
            label8 = new Label();
            label11 = new Label();
            txtModificacionDosis = new TextBox();
            label12 = new Label();
            txtModificacionLaboratorio = new TextBox();
            label13 = new Label();
            label14 = new Label();
            dgvPrescripciones = new DataGridView();
            pnlAddPrescripcion = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtPautas = new TextBox();
            label10 = new Label();
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
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnExcel = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            pnlModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescripciones).BeginInit();
            pnlAddPrescripcion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddPrescipcion);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBuscarNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 1;
            // 
            // btnAddPrescipcion
            // 
            btnAddPrescipcion.BackColor = Color.MediumSeaGreen;
            btnAddPrescipcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPrescipcion.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAddPrescipcion.IconColor = Color.Black;
            btnAddPrescipcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPrescipcion.IconSize = 20;
            btnAddPrescipcion.Location = new Point(518, 58);
            btnAddPrescipcion.Name = "btnAddPrescipcion";
            btnAddPrescipcion.Size = new Size(171, 31);
            btnAddPrescipcion.TabIndex = 20;
            btnAddPrescipcion.Text = "Añadir prescripción";
            btnAddPrescipcion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPrescipcion.UseVisualStyleBackColor = false;
            btnAddPrescipcion.Click += btnAddPrescipcion_Click_1;
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
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
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
            // pnlModificacion
            // 
            pnlModificacion.BackColor = Color.Khaki;
            pnlModificacion.Controls.Add(iconButton2);
            pnlModificacion.Controls.Add(iconButton1);
            pnlModificacion.Controls.Add(txtModificarFrecuencia);
            pnlModificacion.Controls.Add(txtModificarMedicamento);
            pnlModificacion.Controls.Add(txtModificacionPautas);
            pnlModificacion.Controls.Add(label8);
            pnlModificacion.Controls.Add(label11);
            pnlModificacion.Controls.Add(txtModificacionDosis);
            pnlModificacion.Controls.Add(label12);
            pnlModificacion.Controls.Add(txtModificacionLaboratorio);
            pnlModificacion.Controls.Add(label13);
            pnlModificacion.Controls.Add(label14);
            pnlModificacion.Location = new Point(3, 3);
            pnlModificacion.Name = "pnlModificacion";
            pnlModificacion.Size = new Size(736, 237);
            pnlModificacion.TabIndex = 18;
            pnlModificacion.Visible = false;
            pnlModificacion.Paint += pnlModificacion_Paint;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.MediumSeaGreen;
            iconButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(457, 140);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(118, 31);
            iconButton2.TabIndex = 22;
            iconButton2.Text = "Cancelar";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.MediumSeaGreen;
            iconButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(457, 78);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 31);
            iconButton1.TabIndex = 21;
            iconButton1.Text = "Guardar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
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
            // pnlAddPrescripcion
            // 
            pnlAddPrescripcion.BackColor = Color.Khaki;
            pnlAddPrescripcion.Controls.Add(pnlModificacion);
            pnlAddPrescripcion.Controls.Add(btnCancelar);
            pnlAddPrescripcion.Controls.Add(btnGuardar);
            pnlAddPrescripcion.Controls.Add(txtPautas);
            pnlAddPrescripcion.Controls.Add(label10);
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
            pnlAddPrescripcion.Location = new Point(12, 117);
            pnlAddPrescripcion.Name = "pnlAddPrescripcion";
            pnlAddPrescripcion.Size = new Size(777, 236);
            pnlAddPrescripcion.TabIndex = 12;
            pnlAddPrescripcion.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MediumSeaGreen;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 20;
            btnCancelar.Location = new Point(493, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 31);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(493, 85);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 31);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
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
            // btnModificar
            // 
            btnModificar.BackColor = Color.MediumSeaGreen;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Modx;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 20;
            btnModificar.Location = new Point(350, 384);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 31);
            btnModificar.TabIndex = 24;
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
            btnSalir.Location = new Point(505, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 31);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.MediumSeaGreen;
            btnBorrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.IconSize = 20;
            btnBorrar.Location = new Point(142, 384);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(162, 31);
            btnBorrar.TabIndex = 26;
            btnBorrar.Text = "Borrar prescripción";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.MediumSeaGreen;
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.Table;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 20;
            btnExcel.Location = new Point(15, 384);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 31);
            btnExcel.TabIndex = 28;
            btnExcel.Text = "Excel";
            btnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // FormPrescripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcel);
            Controls.Add(btnBorrar);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(pnlAddPrescripcion);
            Controls.Add(dgvPrescripciones);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrescripciones";
            Text = "FormPrescripciones";
            Load += FormPrescripciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlModificacion.ResumeLayout(false);
            pnlModificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescripciones).EndInit();
            pnlAddPrescripcion.ResumeLayout(false);
            pnlAddPrescripcion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscarNombre;
        private Label label1;
        private ComboBox cmbEstado;
        private Label label2;
        private DataGridView dgvPrescripciones;
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
        private TextBox txtPautas;
        private Label label10;
        private Panel pnlModificacion;
        private TextBox txtModificacionPautas;
        private Label label8;
        private Label label11;
        private TextBox txtModificacionDosis;
        private Label label12;
        private TextBox txtModificacionLaboratorio;
        private Label label13;
        private Label label14;
        private TextBox txtModificarFrecuencia;
        private TextBox txtModificarMedicamento;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnAddPrescipcion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnExcel;
    }
}