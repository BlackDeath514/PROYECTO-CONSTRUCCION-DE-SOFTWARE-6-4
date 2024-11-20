namespace CapaPresentacion
{
    partial class frmRegistrarMantenimiento
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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            chklRepuestos = new CheckedListBox();
            label7 = new Label();
            FechaReparacion = new DateTimePicker();
            label6 = new Label();
            rtxtDiagnostico = new RichTextBox();
            cmbTecnico = new ComboBox();
            cmbCelular = new ComboBox();
            cmbCliente = new ComboBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(chklRepuestos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(FechaReparacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(rtxtDiagnostico);
            groupBox1.Controls.Add(cmbTecnico);
            groupBox1.Controls.Add(cmbCelular);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Mantenimiento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(274, 192);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 18;
            label12.Text = "$15";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(274, 174);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 17;
            label11.Text = "$10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 156);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 16;
            label10.Text = "$15";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(274, 137);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 15;
            label9.Text = "$20";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(274, 118);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 14;
            label8.Text = "$30";
            // 
            // chklRepuestos
            // 
            chklRepuestos.FormattingEnabled = true;
            chklRepuestos.Items.AddRange(new object[] { "Pantalla.", "Batería", "Accesorios", "Botones", "Carcaza" });
            chklRepuestos.Location = new Point(299, 116);
            chklRepuestos.Name = "chklRepuestos";
            chklRepuestos.Size = new Size(132, 94);
            chklRepuestos.TabIndex = 13;
            chklRepuestos.SelectedIndexChanged += chklRepuestos_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 95);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "Repuestos:";
            // 
            // FechaReparacion
            // 
            FechaReparacion.Location = new Point(269, 56);
            FechaReparacion.Name = "FechaReparacion";
            FechaReparacion.Size = new Size(200, 23);
            FechaReparacion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 38);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 10;
            label6.Text = "Fecha de reparacion";
            // 
            // rtxtDiagnostico
            // 
            rtxtDiagnostico.Location = new Point(26, 249);
            rtxtDiagnostico.Name = "rtxtDiagnostico";
            rtxtDiagnostico.Size = new Size(443, 113);
            rtxtDiagnostico.TabIndex = 9;
            rtxtDiagnostico.Text = "";
            // 
            // cmbTecnico
            // 
            cmbTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.Location = new Point(81, 158);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Size = new Size(121, 23);
            cmbTecnico.TabIndex = 8;
            // 
            // cmbCelular
            // 
            cmbCelular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCelular.FormattingEnabled = true;
            cmbCelular.Location = new Point(81, 116);
            cmbCelular.Name = "cmbCelular";
            cmbCelular.Size = new Size(121, 23);
            cmbCelular.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(81, 74);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 6;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(81, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 218);
            label5.Name = "label5";
            label5.Size = new Size(179, 15);
            label5.TabIndex = 4;
            label5.Text = "Diagnostico y trabajos realizados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 161);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Tecnico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Celular:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Location = new Point(12, 386);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 112);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(372, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(202, 41);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(97, 40);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(40, 41);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmRegistrarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 513);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmRegistrarMantenimiento";
            Text = "frmRegistrarMantenimiento";
            Load += frmRegistrarMantenimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private Label label6;
        private RichTextBox rtxtDiagnostico;
        private ComboBox cmbTecnico;
        private ComboBox cmbCelular;
        private ComboBox cmbCliente;
        private CheckedListBox chklRepuestos;
        private Label label7;
        private DateTimePicker FechaReparacion;
        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Button btnNuevo;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}