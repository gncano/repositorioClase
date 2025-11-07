namespace TierraMedia
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            btnSolicitar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(192, 176);
            label1.Name = "label1";
            label1.Size = new Size(119, 22);
            label1.TabIndex = 0;
            label1.Text = "Su nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(136, 35);
            label2.Name = "label2";
            label2.Size = new Size(464, 38);
            label2.TabIndex = 1;
            label2.Text = "Banco de la Tierra Media";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(334, 176);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnSolicitar
            // 
            btnSolicitar.BackColor = Color.Sienna;
            btnSolicitar.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolicitar.ForeColor = SystemColors.Control;
            btnSolicitar.Location = new Point(334, 234);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(99, 50);
            btnSolicitar.TabIndex = 4;
            btnSolicitar.Text = "Solicitar Préstamo";
            btnSolicitar.UseVisualStyleBackColor = false;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 0);
            btnSalir.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Linen;
            btnSalir.Location = new Point(693, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(99, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 135, 59);
            ClientSize = new Size(808, 465);
            Controls.Add(btnSalir);
            Controls.Add(btnSolicitar);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private Button btnSolicitar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}
