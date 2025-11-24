namespace MedicinasResidenciaCanoGonzalo
{
    partial class FormMenuPrincipal
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
            lblBienvenido = new Label();
            btnResidentes = new Button();
            btnPrescripciones = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(12, 9);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(69, 15);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido ";
            // 
            // btnResidentes
            // 
            btnResidentes.Location = new Point(450, 88);
            btnResidentes.Name = "btnResidentes";
            btnResidentes.Size = new Size(216, 55);
            btnResidentes.TabIndex = 1;
            btnResidentes.Text = "Abrir el formulario de Residentes";
            btnResidentes.UseVisualStyleBackColor = true;
            btnResidentes.Click += btnResidentes_Click;
            // 
            // btnPrescripciones
            // 
            btnPrescripciones.Location = new Point(450, 199);
            btnPrescripciones.Name = "btnPrescripciones";
            btnPrescripciones.Size = new Size(216, 55);
            btnPrescripciones.TabIndex = 2;
            btnPrescripciones.Text = "Abrir el formulario de Prescripciones";
            btnPrescripciones.UseVisualStyleBackColor = true;
            btnPrescripciones.Click += btnPrescripciones_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(450, 313);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(216, 55);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnPrescripciones);
            Controls.Add(btnResidentes);
            Controls.Add(lblBienvenido);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnResidentes;
        private Button btnPrescripciones;
        private Button btnCerrarSesion;
    }
}