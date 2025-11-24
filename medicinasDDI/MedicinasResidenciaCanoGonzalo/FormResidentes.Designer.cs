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
            panel1 = new Panel();
            btnAlta = new Button();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            dgvResidentes = new DataGridView();
            btnBaja = new Button();
            btnModificar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
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
            btnAlta.Location = new Point(518, 58);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 3;
            btnAlta.Text = "Dar de Alta";
            btnAlta.UseVisualStyleBackColor = true;
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
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Location = new Point(21, 137);
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidentes.Size = new Size(730, 220);
            dgvResidentes.TabIndex = 1;
            dgvResidentes.CellContentClick += dgvResidentes_CellContentClick;
            // 
            // btnBaja
            // 
            btnBaja.Enabled = false;
            btnBaja.Location = new Point(134, 393);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 4;
            btnBaja.Text = "Dar de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(384, 393);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FormResidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(dgvResidentes);
            Controls.Add(panel1);
            Name = "FormResidentes";
            Text = "FormResidentes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAlta;
        private Button btnBuscar;
        private TextBox txtBuscarNombre;
        private Label label1;
        private DataGridView dgvResidentes;
        private Button btnBaja;
        private Button btnModificar;
    }
}