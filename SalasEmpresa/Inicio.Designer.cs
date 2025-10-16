namespace SalasEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            btnAceptar = new Button();
            txtContraseña = new TextBox();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ckbRefrigerio = new CheckBox();
            btnCerrarSesion = new Button();
            cmbHora = new ComboBox();
            cmbSala = new ComboBox();
            label5 = new Label();
            btnReservar = new Button();
            txtNumAsistentes = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            cmbBocadito = new ComboBox();
            cmbBebida = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtIdentificacion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 109);
            panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(486, 46);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 36);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(201, 60);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(187, 23);
            txtContraseña.TabIndex = 3;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(201, 23);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(187, 23);
            txtIdentificacion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 16);
            label1.TabIndex = 0;
            label1.Text = "Identificación ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(ckbRefrigerio);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(cmbHora);
            panel2.Controls.Add(cmbSala);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnReservar);
            panel2.Controls.Add(txtNumAsistentes);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(58, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 149);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // ckbRefrigerio
            // 
            ckbRefrigerio.AutoSize = true;
            ckbRefrigerio.Location = new Point(77, 116);
            ckbRefrigerio.Name = "ckbRefrigerio";
            ckbRefrigerio.Size = new Size(77, 19);
            ckbRefrigerio.TabIndex = 9;
            ckbRefrigerio.Text = "Refrigerio";
            ckbRefrigerio.UseVisualStyleBackColor = true;
            ckbRefrigerio.CheckedChanged += ckbRefrigerio_CheckedChanged;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(486, 79);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(125, 36);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // cmbHora
            // 
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(289, 87);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(121, 23);
            cmbHora.TabIndex = 7;
            // 
            // cmbSala
            // 
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(75, 87);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(121, 23);
            cmbSala.TabIndex = 6;
            cmbSala.SelectedIndexChanged += cmbSala_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(241, 89);
            label5.Name = "label5";
            label5.Size = new Size(42, 16);
            label5.TabIndex = 5;
            label5.Text = "Hora";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(486, 33);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(125, 36);
            btnReservar.TabIndex = 4;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // txtNumAsistentes
            // 
            txtNumAsistentes.Location = new Point(201, 41);
            txtNumAsistentes.Name = "txtNumAsistentes";
            txtNumAsistentes.Size = new Size(187, 23);
            txtNumAsistentes.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 1;
            label3.Text = "Sala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 43);
            label4.Name = "label4";
            label4.Size = new Size(166, 16);
            label4.TabIndex = 0;
            label4.Text = "Numero de asistentes";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(677, 376);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 43);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbBocadito);
            panel3.Controls.Add(cmbBebida);
            panel3.Location = new Point(58, 342);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 89);
            panel3.TabIndex = 9;
            panel3.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 27);
            label7.Name = "label7";
            label7.Size = new Size(57, 16);
            label7.TabIndex = 10;
            label7.Text = "Bebida";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(262, 27);
            label8.Name = "label8";
            label8.Size = new Size(71, 16);
            label8.TabIndex = 9;
            label8.Text = "Bocadito";
            // 
            // cmbBocadito
            // 
            cmbBocadito.FormattingEnabled = true;
            cmbBocadito.Location = new Point(339, 24);
            cmbBocadito.Name = "cmbBocadito";
            cmbBocadito.Size = new Size(121, 23);
            cmbBocadito.TabIndex = 3;
            // 
            // cmbBebida
            // 
            cmbBebida.FormattingEnabled = true;
            cmbBebida.Location = new Point(93, 24);
            cmbBebida.Name = "cmbBebida";
            cmbBebida.Size = new Size(121, 23);
            cmbBebida.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Reservar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private TextBox txtContraseña;
        private TextBox txtIdentificacion;
        private Panel panel2;
        private Button btnReservar;
        private TextBox txtNumAsistentes;
        private Label label3;
        private Label label4;
        private ComboBox cmbHora;
        private ComboBox cmbSala;
        private Label label5;
        private Button btnCerrarSesion;
        private Button btnSalir;
        private Panel panel3;
        private Label label8;
        private ComboBox cmbBocadito;
        private ComboBox cmbBebida;
        private CheckBox ckbRefrigerio;
        private Label label7;
    }
}
