namespace CapaPresentacion
{
    partial class frmPrincipal
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
            groupBox1 = new GroupBox();
            lblIntegrante = new Label();
            groupBox2 = new GroupBox();
            btnREquipo = new Button();
            btnMantenimiento = new Button();
            btnRegistrarTecnico = new Button();
            btnRegistrarCliente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIntegrante);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio";
            // 
            // lblIntegrante
            // 
            lblIntegrante.AutoSize = true;
            lblIntegrante.Location = new Point(23, 33);
            lblIntegrante.Name = "lblIntegrante";
            lblIntegrante.Size = new Size(66, 15);
            lblIntegrante.TabIndex = 0;
            lblIntegrante.Text = "Integrantes";
            lblIntegrante.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnREquipo);
            groupBox2.Controls.Add(btnMantenimiento);
            groupBox2.Controls.Add(btnRegistrarTecnico);
            groupBox2.Controls.Add(btnRegistrarCliente);
            groupBox2.Location = new Point(384, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // btnREquipo
            // 
            btnREquipo.Location = new Point(17, 94);
            btnREquipo.Name = "btnREquipo";
            btnREquipo.Size = new Size(186, 38);
            btnREquipo.TabIndex = 3;
            btnREquipo.Text = "Registrar Equipo";
            btnREquipo.UseVisualStyleBackColor = true;
            btnREquipo.Click += btnREquipo_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.Location = new Point(17, 216);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(186, 38);
            btnMantenimiento.TabIndex = 2;
            btnMantenimiento.Text = "Registrar Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = true;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // btnRegistrarTecnico
            // 
            btnRegistrarTecnico.Location = new Point(18, 158);
            btnRegistrarTecnico.Name = "btnRegistrarTecnico";
            btnRegistrarTecnico.Size = new Size(186, 38);
            btnRegistrarTecnico.TabIndex = 1;
            btnRegistrarTecnico.Text = "Registrar Tecnico";
            btnRegistrarTecnico.UseVisualStyleBackColor = true;
            btnRegistrarTecnico.Click += btnRegistrarTecnico_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(18, 33);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(186, 36);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 326);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnRegistrarCliente;
        private Button btnMantenimiento;
        private Button btnRegistrarTecnico;
        private Label lblIntegrante;
        private Button btnREquipo;
    }
}