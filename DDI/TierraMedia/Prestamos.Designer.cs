namespace TierraMedia
{
    partial class Prestamos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            lblSaludo = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cmbLugar = new ComboBox();
            label5 = new Label();
            cmbRaza = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            txtbPrestamo = new TextBox();
            cmbCuotas = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnVolver = new Button();
            btnConfirmar = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.SaddleBrown;
            lblSaludo.Location = new Point(37, 38);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(168, 29);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Bienvenido, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(100, 117);
            label2.Name = "label2";
            label2.Size = new Size(160, 18);
            label2.TabIndex = 1;
            label2.Text = "Datos personales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(cmbLugar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbRaza);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(83, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 132);
            panel1.TabIndex = 2;
            // 
            // cmbLugar
            // 
            cmbLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(146, 80);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(150, 23);
            cmbLugar.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(137, 19);
            label5.TabIndex = 2;
            label5.Text = "Lugar de origen";
            // 
            // cmbRaza
            // 
            cmbRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaza.FormattingEnabled = true;
            cmbRaza.Location = new Point(146, 35);
            cmbRaza.Name = "cmbRaza";
            cmbRaza.Size = new Size(150, 23);
            cmbRaza.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(90, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 0;
            label4.Text = "Raza";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(txtbPrestamo);
            panel2.Controls.Add(cmbCuotas);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(391, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 132);
            panel2.TabIndex = 4;
            // 
            // txtbPrestamo
            // 
            txtbPrestamo.Location = new Point(146, 35);
            txtbPrestamo.Name = "txtbPrestamo";
            txtbPrestamo.Size = new Size(150, 23);
            txtbPrestamo.TabIndex = 6;
            // 
            // cmbCuotas
            // 
            cmbCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Location = new Point(146, 81);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(150, 23);
            cmbCuotas.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(75, 84);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 4;
            label7.Text = "Cuotas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(54, 34);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 2;
            label6.Text = "préstamo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(450, 117);
            label3.Name = "label3";
            label3.Size = new Size(189, 18);
            label3.TabIndex = 3;
            label3.Text = "Detalle del préstamo";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 128, 0);
            btnVolver.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Linen;
            btnVolver.Location = new Point(693, 399);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 50);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Sienna;
            btnConfirmar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Control;
            btnConfirmar.Location = new Point(334, 306);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 50);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar solicitud";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 135, 59);
            ClientSize = new Size(804, 461);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lblSaludo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Prestamos";
            Text = "Prestamos";
            Load += Prestamos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button btnVolver;
        private Button btnConfirmar;
        private ComboBox cmbLugar;
        private Label label5;
        private ComboBox cmbRaza;
        private ComboBox cmbCuotas;
        private Label label7;
        private Label label6;
        private TextBox txtbPrestamo;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}