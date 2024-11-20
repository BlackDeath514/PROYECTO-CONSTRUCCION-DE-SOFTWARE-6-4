namespace ReparacionesDB
{
    partial class Login
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            lblUsuario = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(txtContrasena);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblContrasena);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de Sesion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CapaPresentacion.Properties.Resources._6073873;
            pictureBox1.Location = new Point(81, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(119, 337);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(101, 38);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(104, 267);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(209, 23);
            txtContrasena.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(104, 218);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(209, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(33, 270);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(33, 221);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblContrasena;
        private Label lblUsuario;
        private Button btnEntrar;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
    }
}
