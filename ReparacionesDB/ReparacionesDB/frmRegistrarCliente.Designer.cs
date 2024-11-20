namespace CapaPresentacion
{
    partial class frmRegistrarCliente
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
            rtxtDireccion = new RichTextBox();
            txtCelular = new TextBox();
            txtCedula = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvClientes = new DataGridView();
            groupBox3 = new GroupBox();
            btnRegresar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxtDireccion);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // rtxtDireccion
            // 
            rtxtDireccion.Location = new Point(83, 137);
            rtxtDireccion.Name = "rtxtDireccion";
            rtxtDireccion.Size = new Size(341, 96);
            rtxtDireccion.TabIndex = 0;
            rtxtDireccion.Text = "";
            rtxtDireccion.TextChanged += rtxtDireccion_TextChanged;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(280, 100);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(144, 23);
            txtCelular.TabIndex = 8;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(83, 100);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(138, 23);
            txtCedula.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(83, 64);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(341, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(341, 23);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 140);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 4;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 103);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 3;
            label5.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 103);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 2;
            label4.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 67);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 24);
            label1.TabIndex = 1;
            label1.Text = "Ingresar Datos Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvClientes);
            groupBox2.Location = new Point(484, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 252);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(292, 211);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegresar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Location = new Point(12, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(600, 53);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(154, 36);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(423, 53);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(227, 53);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(29, 53);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(154, 36);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegistrarCliente";
            Text = "frmRegistrarCliente";
            Load += frmRegistrarCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtCelular;
        private TextBox txtCedula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox rtxtDireccion;
        private DataGridView dgvClientes;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}