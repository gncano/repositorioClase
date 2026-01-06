namespace MedicinasResidenciaCanoGonzalo
{
    partial class FormInformes
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
            btnAceptar = new Button();
            btnAdd = new Button();
            chbDosis = new CheckBox();
            chbEstado = new CheckBox();
            chbFechaModificacion = new CheckBox();
            chbFechaInicio = new CheckBox();
            chbIdResidente = new CheckBox();
            chbHabitacion = new CheckBox();
            chbFechaEntrada = new CheckBox();
            label2 = new Label();
            chbMedicamento = new CheckBox();
            label1 = new Label();
            chbNombre = new CheckBox();
            dgvInforme = new DataGridView();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnPdf = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(chbDosis);
            panel1.Controls.Add(chbEstado);
            panel1.Controls.Add(chbFechaModificacion);
            panel1.Controls.Add(chbFechaInicio);
            panel1.Controls.Add(chbIdResidente);
            panel1.Controls.Add(chbHabitacion);
            panel1.Controls.Add(chbFechaEntrada);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chbMedicamento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 450);
            panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(184, 395);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 23);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Añadir todos los campos";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // chbDosis
            // 
            chbDosis.AutoSize = true;
            chbDosis.Location = new Point(31, 326);
            chbDosis.Name = "chbDosis";
            chbDosis.Size = new Size(54, 19);
            chbDosis.TabIndex = 11;
            chbDosis.Text = "Dosis";
            chbDosis.UseVisualStyleBackColor = true;
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Location = new Point(31, 301);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(61, 19);
            chbEstado.TabIndex = 10;
            chbEstado.Text = "Estado";
            chbEstado.UseVisualStyleBackColor = true;
            // 
            // chbFechaModificacion
            // 
            chbFechaModificacion.AutoSize = true;
            chbFechaModificacion.Location = new Point(31, 276);
            chbFechaModificacion.Name = "chbFechaModificacion";
            chbFechaModificacion.Size = new Size(146, 19);
            chbFechaModificacion.TabIndex = 9;
            chbFechaModificacion.Text = "Fecha de modificación";
            chbFechaModificacion.UseVisualStyleBackColor = true;
            // 
            // chbFechaInicio
            // 
            chbFechaInicio.AutoSize = true;
            chbFechaInicio.Location = new Point(31, 251);
            chbFechaInicio.Name = "chbFechaInicio";
            chbFechaInicio.Size = new Size(105, 19);
            chbFechaInicio.TabIndex = 8;
            chbFechaInicio.Text = "Fecha de inicio";
            chbFechaInicio.UseVisualStyleBackColor = true;
            // 
            // chbIdResidente
            // 
            chbIdResidente.AutoSize = true;
            chbIdResidente.Location = new Point(31, 131);
            chbIdResidente.Name = "chbIdResidente";
            chbIdResidente.Size = new Size(87, 19);
            chbIdResidente.TabIndex = 7;
            chbIdResidente.Text = "Id residente";
            chbIdResidente.UseVisualStyleBackColor = true;
            // 
            // chbHabitacion
            // 
            chbHabitacion.AutoSize = true;
            chbHabitacion.Location = new Point(31, 106);
            chbHabitacion.Name = "chbHabitacion";
            chbHabitacion.Size = new Size(84, 19);
            chbHabitacion.TabIndex = 5;
            chbHabitacion.Text = "Habitación";
            chbHabitacion.UseVisualStyleBackColor = true;
            // 
            // chbFechaEntrada
            // 
            chbFechaEntrada.AutoSize = true;
            chbFechaEntrada.Location = new Point(31, 81);
            chbFechaEntrada.Name = "chbFechaEntrada";
            chbFechaEntrada.Size = new Size(116, 19);
            chbFechaEntrada.TabIndex = 4;
            chbFechaEntrada.Text = "Fecha de entrada";
            chbFechaEntrada.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 195);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 3;
            label2.Text = "Información de la prescipción";
            // 
            // chbMedicamento
            // 
            chbMedicamento.AutoSize = true;
            chbMedicamento.Location = new Point(31, 227);
            chbMedicamento.Name = "chbMedicamento";
            chbMedicamento.Size = new Size(100, 19);
            chbMedicamento.TabIndex = 2;
            chbMedicamento.Text = "Medicamento";
            chbMedicamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 1;
            label1.Text = "Información del residente";
            // 
            // chbNombre
            // 
            chbNombre.AutoSize = true;
            chbNombre.Location = new Point(31, 56);
            chbNombre.Name = "chbNombre";
            chbNombre.Size = new Size(124, 19);
            chbNombre.TabIndex = 0;
            chbNombre.Text = "Nombre completo";
            chbNombre.UseVisualStyleBackColor = true;
            // 
            // dgvInforme
            // 
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(286, 12);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.Size = new Size(502, 351);
            dgvInforme.TabIndex = 1;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.MediumSeaGreen;
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 20;
            btnExcel.Location = new Point(355, 395);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 31);
            btnExcel.TabIndex = 27;
            btnExcel.Text = "Excel";
            btnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.MediumSeaGreen;
            btnPdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnPdf.IconColor = Color.Black;
            btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPdf.IconSize = 20;
            btnPdf.Location = new Point(535, 395);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(94, 31);
            btnPdf.TabIndex = 28;
            btnPdf.Text = "PDF";
            btnPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPdf);
            Controls.Add(btnExcel);
            Controls.Add(dgvInforme);
            Controls.Add(panel1);
            Name = "FormInformes";
            Text = "FormInformes";
            Load += FormInformes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private CheckBox chbMedicamento;
        private Label label1;
        private CheckBox chbNombre;
        private CheckBox chbFechaEntrada;
        private CheckBox chbIdResidente;
        private CheckBox chbHabitacion;
        private CheckBox chbDosis;
        private CheckBox chbEstado;
        private CheckBox chbFechaModificacion;
        private CheckBox chbFechaInicio;
        private DataGridView dgvInforme;
        private Button btnAceptar;
        private Button btnAdd;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnPdf;
    }
}