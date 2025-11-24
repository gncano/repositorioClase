namespace MedicinasResidenciaCanoGonzalo
{
    partial class FormLogin
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
            lblUsuario = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIniciarSesion = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(204, 110);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 191);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Clave";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(359, 107);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(359, 183);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(200, 23);
            txtClave.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(191, 320);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(124, 23);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "INICIAR SESION";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(421, 320);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIniciarSesion;
        private Button btnSalir;
    }
}