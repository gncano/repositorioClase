namespace CapaPresentacion
{
    partial class Login
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            btnIniciar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 236);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 153;
            iconPictureBox1.Location = new Point(35, 29);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(153, 157);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 202);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE VENTAS";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 32);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 1;
            label2.Text = "INICIAR SESIÓN";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(296, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 2;
            label3.Text = "USUARIO";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(296, 136);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 3;
            label4.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(296, 102);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(142, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.Tag = "";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(296, 162);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(142, 23);
            txtContra.TabIndex = 5;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.RoyalBlue;
            btnIniciar.FlatAppearance.BorderColor = Color.White;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIniciar.IconColor = Color.White;
            btnIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIniciar.IconSize = 21;
            btnIniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciar.Location = new Point(259, 201);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(125, 23);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "INICIAR SESION";
            btnIniciar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.ForeColor = SystemColors.Window;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 21;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(390, 201);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 236);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContra;
       
        private FontAwesome.Sharp.IconButton btnIniciar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}