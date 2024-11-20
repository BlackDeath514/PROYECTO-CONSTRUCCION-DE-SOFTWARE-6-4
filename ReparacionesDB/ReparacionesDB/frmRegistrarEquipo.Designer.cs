namespace CapaPresentacion
{
    partial class frmRegistrarEquipo
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
            txtDetalles = new RichTextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbliente = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            DGVequipos = new DataGridView();
            groupBox3 = new GroupBox();
            regreso = new Button();
            btnGuardar = new Button();
            btNuevo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVequipos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDetalles);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbliente);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del equipo";
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(13, 181);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(379, 96);
            txtDetalles.TabIndex = 7;
            txtDetalles.Text = "";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(66, 117);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(229, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(66, 69);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(229, 23);
            txtModelo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 158);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Detalles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 120);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 77);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // cbliente
            // 
            cbliente.FormattingEnabled = true;
            cbliente.Location = new Point(66, 28);
            cbliente.Name = "cbliente";
            cbliente.Size = new Size(229, 23);
            cbliente.TabIndex = 0;
            cbliente.SelectedIndexChanged += cbliente_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 1;
            label1.Text = "Ingresar Equipos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DGVequipos);
            groupBox2.Location = new Point(456, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 297);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // DGVequipos
            // 
            DGVequipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVequipos.Location = new Point(12, 28);
            DGVequipos.Name = "DGVequipos";
            DGVequipos.Size = new Size(326, 249);
            DGVequipos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(regreso);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(btNuevo);
            groupBox3.Location = new Point(12, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(795, 92);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // regreso
            // 
            regreso.Location = new Point(509, 32);
            regreso.Name = "regreso";
            regreso.Size = new Size(154, 36);
            regreso.TabIndex = 3;
            regreso.Text = "Regresar";
            regreso.UseVisualStyleBackColor = true;
            regreso.Click += regreso_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(318, 32);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btNuevo
            // 
            btNuevo.Location = new Point(126, 32);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(154, 36);
            btNuevo.TabIndex = 0;
            btNuevo.Text = "Nuevo";
            btNuevo.UseVisualStyleBackColor = true;
            btNuevo.Click += btNuevo_Click;
            // 
            // frmRegistrarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 477);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegistrarEquipo";
            Text = "frmRegistrarEquipo";
            Load += frmRegistrarEquipo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVequipos).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbliente;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtDetalles;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private GroupBox groupBox2;
        private DataGridView DGVequipos;
        private GroupBox groupBox3;
        private Button btnGuardar;
        private Button btNuevo;
        private Button regreso;
    }
}