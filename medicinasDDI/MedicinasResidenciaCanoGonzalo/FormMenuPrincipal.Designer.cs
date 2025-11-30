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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnResidentes = new FontAwesome.Sharp.IconButton();
            btnPrescripciones = new FontAwesome.Sharp.IconButton();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 452);
            panel1.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Khaki;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Pills;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 217;
            iconPictureBox1.Location = new Point(83, 56);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(261, 217);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // btnResidentes
            // 
            btnResidentes.BackColor = Color.MediumSeaGreen;
            btnResidentes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResidentes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnResidentes.IconColor = Color.Black;
            btnResidentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResidentes.Location = new Point(486, 74);
            btnResidentes.Name = "btnResidentes";
            btnResidentes.Size = new Size(216, 54);
            btnResidentes.TabIndex = 5;
            btnResidentes.Text = "Formulario de Residentes";
            btnResidentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResidentes.UseVisualStyleBackColor = false;
            btnResidentes.Click += btnResidentes_Click_1;
            // 
            // btnPrescripciones
            // 
            btnPrescripciones.BackColor = Color.MediumSeaGreen;
            btnPrescripciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrescripciones.IconChar = FontAwesome.Sharp.IconChar.File;
            btnPrescripciones.IconColor = Color.Black;
            btnPrescripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrescripciones.Location = new Point(486, 199);
            btnPrescripciones.Name = "btnPrescripciones";
            btnPrescripciones.Size = new Size(216, 54);
            btnPrescripciones.TabIndex = 6;
            btnPrescripciones.Text = "Formulario de Prescripciones";
            btnPrescripciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrescripciones.UseVisualStyleBackColor = false;
            btnPrescripciones.Click += btnPrescripciones_Click_1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Salmon;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnCerrarSesion.IconColor = Color.Black;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.Location = new Point(486, 333);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(216, 54);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnPrescripciones);
            Controls.Add(btnResidentes);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnResidentes;
        private FontAwesome.Sharp.IconButton btnPrescripciones;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}