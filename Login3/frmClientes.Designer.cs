namespace DashBoard1
{
    partial class frmClientes
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
            this.pnlClienteAgregar = new System.Windows.Forms.Panel();
            this.lblProvinciaClienteAgregar = new System.Windows.Forms.Label();
            this.cbbProvinciaClienteAgregar = new System.Windows.Forms.ComboBox();
            this.lblAgregarUnCliente = new System.Windows.Forms.Label();
            this.btnGuardarClienteAgregar = new System.Windows.Forms.PictureBox();
            this.rdbSinEspecificarClienteAgregar = new System.Windows.Forms.RadioButton();
            this.rdbMujerClienteAgregar = new System.Windows.Forms.RadioButton();
            this.rdbHombreClienteAgregar = new System.Windows.Forms.RadioButton();
            this.lblGeneroClienteAgregar = new System.Windows.Forms.Label();
            this.txtCedulaClienteAgregar = new System.Windows.Forms.TextBox();
            this.lblCedulaClienteAgregar = new System.Windows.Forms.Label();
            this.txtApellidoClienteAgregar = new System.Windows.Forms.TextBox();
            this.lblApellidoClienteAgregar = new System.Windows.Forms.Label();
            this.lblNombreClienteAgregar = new System.Windows.Forms.Label();
            this.txtNombreClienteAgregar = new System.Windows.Forms.TextBox();
            this.pnlHistorialCliente = new System.Windows.Forms.Panel();
            this.dgvHistorialCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscarHistorial = new System.Windows.Forms.PictureBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.txtCedulaHistorial = new System.Windows.Forms.TextBox();
            this.lblCedulaHistorial = new System.Windows.Forms.Label();
            this.lblApellidoHistorial = new System.Windows.Forms.Label();
            this.txtApellidoHistorial = new System.Windows.Forms.TextBox();
            this.txtNombreHistorial = new System.Windows.Forms.TextBox();
            this.lblNombreHistorial = new System.Windows.Forms.Label();
            this.pnlBuscarCliente = new System.Windows.Forms.Panel();
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.pnlClienteAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarClienteAgregar)).BeginInit();
            this.pnlHistorialCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarHistorial)).BeginInit();
            this.pnlBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClienteAgregar
            // 
            this.pnlClienteAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlClienteAgregar.Controls.Add(this.lblProvinciaClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.cbbProvinciaClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.lblAgregarUnCliente);
            this.pnlClienteAgregar.Controls.Add(this.btnGuardarClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.rdbSinEspecificarClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.rdbMujerClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.rdbHombreClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.lblGeneroClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.txtCedulaClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.lblCedulaClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.txtApellidoClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.lblApellidoClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.lblNombreClienteAgregar);
            this.pnlClienteAgregar.Controls.Add(this.txtNombreClienteAgregar);
            this.pnlClienteAgregar.Location = new System.Drawing.Point(755, 12);
            this.pnlClienteAgregar.Name = "pnlClienteAgregar";
            this.pnlClienteAgregar.Size = new System.Drawing.Size(317, 373);
            this.pnlClienteAgregar.TabIndex = 0;
            this.pnlClienteAgregar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClienteAgregar_Paint);
            // 
            // lblProvinciaClienteAgregar
            // 
            this.lblProvinciaClienteAgregar.AutoSize = true;
            this.lblProvinciaClienteAgregar.Location = new System.Drawing.Point(45, 204);
            this.lblProvinciaClienteAgregar.Name = "lblProvinciaClienteAgregar";
            this.lblProvinciaClienteAgregar.Size = new System.Drawing.Size(51, 13);
            this.lblProvinciaClienteAgregar.TabIndex = 13;
            this.lblProvinciaClienteAgregar.Text = "Provincia";
            this.lblProvinciaClienteAgregar.Click += new System.EventHandler(this.lblProvinciaClienteAgregar_Click);
            // 
            // cbbProvinciaClienteAgregar
            // 
            this.cbbProvinciaClienteAgregar.FormattingEnabled = true;
            this.cbbProvinciaClienteAgregar.Items.AddRange(new object[] {
            "Azúa",
            "Baoruco ",
            "Barahona  ",
            "Dajabón",
            "Distrito Nacional",
            "Duarte",
            "Elías Pina",
            "El Seibo",
            "Espaillat",
            "Hato Mayor",
            "Independencia",
            "La Altagracia",
            "La Romana",
            "La Vega",
            "Maria Trinidad Sanchez",
            "Monseñor Nouel",
            "Monte Cristi",
            "Monte Plata",
            "Pedernales",
            "Peravia",
            "Puerto Plata",
            "Salcedo",
            "Samana",
            "Sánchez Ramírez",
            "San Cristobal",
            "San Jose de Ocoa",
            "San Juan",
            "San Pedro de Macorís",
            "Santiago",
            "Santiago Rodríguez",
            "Santo Domingo",
            "Valverde"});
            this.cbbProvinciaClienteAgregar.Location = new System.Drawing.Point(48, 220);
            this.cbbProvinciaClienteAgregar.Name = "cbbProvinciaClienteAgregar";
            this.cbbProvinciaClienteAgregar.Size = new System.Drawing.Size(121, 21);
            this.cbbProvinciaClienteAgregar.TabIndex = 12;
            this.cbbProvinciaClienteAgregar.Text = "-Elija la provincia-";
            this.cbbProvinciaClienteAgregar.SelectedIndexChanged += new System.EventHandler(this.cbbProvinciaClienteAgregar_SelectedIndexChanged);
            // 
            // lblAgregarUnCliente
            // 
            this.lblAgregarUnCliente.AutoSize = true;
            this.lblAgregarUnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarUnCliente.Location = new System.Drawing.Point(51, 29);
            this.lblAgregarUnCliente.Name = "lblAgregarUnCliente";
            this.lblAgregarUnCliente.Size = new System.Drawing.Size(233, 31);
            this.lblAgregarUnCliente.TabIndex = 11;
            this.lblAgregarUnCliente.Text = "Agregar un cliente";
            this.lblAgregarUnCliente.Click += new System.EventHandler(this.lblAgregarUnCliente_Click);
            // 
            // btnGuardarClienteAgregar
            // 
            this.btnGuardarClienteAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClienteAgregar.Image = global::DashBoard1.Properties.Resources.guardar;
            this.btnGuardarClienteAgregar.Location = new System.Drawing.Point(137, 309);
            this.btnGuardarClienteAgregar.Name = "btnGuardarClienteAgregar";
            this.btnGuardarClienteAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardarClienteAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardarClienteAgregar.TabIndex = 10;
            this.btnGuardarClienteAgregar.TabStop = false;
            this.btnGuardarClienteAgregar.Click += new System.EventHandler(this.btnGuardarClienteAgregar_Click);
            // 
            // rdbSinEspecificarClienteAgregar
            // 
            this.rdbSinEspecificarClienteAgregar.AutoSize = true;
            this.rdbSinEspecificarClienteAgregar.Location = new System.Drawing.Point(183, 184);
            this.rdbSinEspecificarClienteAgregar.Name = "rdbSinEspecificarClienteAgregar";
            this.rdbSinEspecificarClienteAgregar.Size = new System.Drawing.Size(94, 17);
            this.rdbSinEspecificarClienteAgregar.TabIndex = 9;
            this.rdbSinEspecificarClienteAgregar.TabStop = true;
            this.rdbSinEspecificarClienteAgregar.Text = "Sin especificar";
            this.rdbSinEspecificarClienteAgregar.UseVisualStyleBackColor = true;
            this.rdbSinEspecificarClienteAgregar.CheckedChanged += new System.EventHandler(this.rdbSinEspecificarClienteAgregar_CheckedChanged);
            // 
            // rdbMujerClienteAgregar
            // 
            this.rdbMujerClienteAgregar.AutoSize = true;
            this.rdbMujerClienteAgregar.Location = new System.Drawing.Point(126, 184);
            this.rdbMujerClienteAgregar.Name = "rdbMujerClienteAgregar";
            this.rdbMujerClienteAgregar.Size = new System.Drawing.Size(51, 17);
            this.rdbMujerClienteAgregar.TabIndex = 8;
            this.rdbMujerClienteAgregar.TabStop = true;
            this.rdbMujerClienteAgregar.Text = "Mujer";
            this.rdbMujerClienteAgregar.UseVisualStyleBackColor = true;
            this.rdbMujerClienteAgregar.CheckedChanged += new System.EventHandler(this.rdbMujerClienteAgregar_CheckedChanged);
            // 
            // rdbHombreClienteAgregar
            // 
            this.rdbHombreClienteAgregar.AutoSize = true;
            this.rdbHombreClienteAgregar.Location = new System.Drawing.Point(51, 184);
            this.rdbHombreClienteAgregar.Name = "rdbHombreClienteAgregar";
            this.rdbHombreClienteAgregar.Size = new System.Drawing.Size(62, 17);
            this.rdbHombreClienteAgregar.TabIndex = 7;
            this.rdbHombreClienteAgregar.TabStop = true;
            this.rdbHombreClienteAgregar.Text = "Hombre";
            this.rdbHombreClienteAgregar.UseVisualStyleBackColor = true;
            this.rdbHombreClienteAgregar.CheckedChanged += new System.EventHandler(this.rdbHombreClienteAgregar_CheckedChanged);
            // 
            // lblGeneroClienteAgregar
            // 
            this.lblGeneroClienteAgregar.AutoSize = true;
            this.lblGeneroClienteAgregar.Location = new System.Drawing.Point(48, 168);
            this.lblGeneroClienteAgregar.Name = "lblGeneroClienteAgregar";
            this.lblGeneroClienteAgregar.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroClienteAgregar.TabIndex = 6;
            this.lblGeneroClienteAgregar.Text = "Género";
            this.lblGeneroClienteAgregar.Click += new System.EventHandler(this.lblGeneroClienteAgregar_Click);
            // 
            // txtCedulaClienteAgregar
            // 
            this.txtCedulaClienteAgregar.Location = new System.Drawing.Point(48, 132);
            this.txtCedulaClienteAgregar.Name = "txtCedulaClienteAgregar";
            this.txtCedulaClienteAgregar.Size = new System.Drawing.Size(233, 20);
            this.txtCedulaClienteAgregar.TabIndex = 5;
            // 
            // lblCedulaClienteAgregar
            // 
            this.lblCedulaClienteAgregar.AutoSize = true;
            this.lblCedulaClienteAgregar.Location = new System.Drawing.Point(45, 116);
            this.lblCedulaClienteAgregar.Name = "lblCedulaClienteAgregar";
            this.lblCedulaClienteAgregar.Size = new System.Drawing.Size(40, 13);
            this.lblCedulaClienteAgregar.TabIndex = 4;
            this.lblCedulaClienteAgregar.Text = "Cédula";
            this.lblCedulaClienteAgregar.Click += new System.EventHandler(this.lblCedulaClienteAgregar_Click);
            // 
            // txtApellidoClienteAgregar
            // 
            this.txtApellidoClienteAgregar.Location = new System.Drawing.Point(170, 88);
            this.txtApellidoClienteAgregar.Name = "txtApellidoClienteAgregar";
            this.txtApellidoClienteAgregar.Size = new System.Drawing.Size(111, 20);
            this.txtApellidoClienteAgregar.TabIndex = 3;
            // 
            // lblApellidoClienteAgregar
            // 
            this.lblApellidoClienteAgregar.AutoSize = true;
            this.lblApellidoClienteAgregar.Location = new System.Drawing.Point(167, 72);
            this.lblApellidoClienteAgregar.Name = "lblApellidoClienteAgregar";
            this.lblApellidoClienteAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoClienteAgregar.TabIndex = 2;
            this.lblApellidoClienteAgregar.Text = "Apellido";
            // 
            // lblNombreClienteAgregar
            // 
            this.lblNombreClienteAgregar.AutoSize = true;
            this.lblNombreClienteAgregar.Location = new System.Drawing.Point(45, 72);
            this.lblNombreClienteAgregar.Name = "lblNombreClienteAgregar";
            this.lblNombreClienteAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreClienteAgregar.TabIndex = 1;
            this.lblNombreClienteAgregar.Text = "Nombre";
            this.lblNombreClienteAgregar.Click += new System.EventHandler(this.lblNombreClienteAgregar_Click);
            // 
            // txtNombreClienteAgregar
            // 
            this.txtNombreClienteAgregar.Location = new System.Drawing.Point(48, 88);
            this.txtNombreClienteAgregar.Name = "txtNombreClienteAgregar";
            this.txtNombreClienteAgregar.Size = new System.Drawing.Size(111, 20);
            this.txtNombreClienteAgregar.TabIndex = 0;
            // 
            // pnlHistorialCliente
            // 
            this.pnlHistorialCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHistorialCliente.Controls.Add(this.dgvHistorialCliente);
            this.pnlHistorialCliente.Controls.Add(this.btnBuscarHistorial);
            this.pnlHistorialCliente.Controls.Add(this.lblHistorial);
            this.pnlHistorialCliente.Controls.Add(this.txtCedulaHistorial);
            this.pnlHistorialCliente.Controls.Add(this.lblCedulaHistorial);
            this.pnlHistorialCliente.Controls.Add(this.lblApellidoHistorial);
            this.pnlHistorialCliente.Controls.Add(this.txtApellidoHistorial);
            this.pnlHistorialCliente.Controls.Add(this.txtNombreHistorial);
            this.pnlHistorialCliente.Controls.Add(this.lblNombreHistorial);
            this.pnlHistorialCliente.Location = new System.Drawing.Point(12, 12);
            this.pnlHistorialCliente.Name = "pnlHistorialCliente";
            this.pnlHistorialCliente.Size = new System.Drawing.Size(439, 506);
            this.pnlHistorialCliente.TabIndex = 1;
            this.pnlHistorialCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHistorialCliente_Paint);
            // 
            // dgvHistorialCliente
            // 
            this.dgvHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCliente.Location = new System.Drawing.Point(14, 204);
            this.dgvHistorialCliente.Name = "dgvHistorialCliente";
            this.dgvHistorialCliente.Size = new System.Drawing.Size(409, 267);
            this.dgvHistorialCliente.TabIndex = 8;
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarHistorial.Image = global::DashBoard1.Properties.Resources.buscar;
            this.btnBuscarHistorial.Location = new System.Drawing.Point(375, 86);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(48, 50);
            this.btnBuscarHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarHistorial.TabIndex = 7;
            this.btnBuscarHistorial.TabStop = false;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(6, 14);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(277, 37);
            this.lblHistorial.TabIndex = 6;
            this.lblHistorial.Text = "Historial de cliente";
            this.lblHistorial.Click += new System.EventHandler(this.lblHistorial_Click);
            // 
            // txtCedulaHistorial
            // 
            this.txtCedulaHistorial.Location = new System.Drawing.Point(112, 113);
            this.txtCedulaHistorial.Name = "txtCedulaHistorial";
            this.txtCedulaHistorial.Size = new System.Drawing.Size(158, 20);
            this.txtCedulaHistorial.TabIndex = 5;
            this.txtCedulaHistorial.TextChanged += new System.EventHandler(this.txtCedulaHistorial_TextChanged);
            // 
            // lblCedulaHistorial
            // 
            this.lblCedulaHistorial.AutoSize = true;
            this.lblCedulaHistorial.Location = new System.Drawing.Point(11, 116);
            this.lblCedulaHistorial.Name = "lblCedulaHistorial";
            this.lblCedulaHistorial.Size = new System.Drawing.Size(91, 13);
            this.lblCedulaHistorial.TabIndex = 4;
            this.lblCedulaHistorial.Text = "Cédula del cliente";
            this.lblCedulaHistorial.Click += new System.EventHandler(this.lblCedulaHistorial_Click);
            // 
            // lblApellidoHistorial
            // 
            this.lblApellidoHistorial.AutoSize = true;
            this.lblApellidoHistorial.Location = new System.Drawing.Point(11, 86);
            this.lblApellidoHistorial.Name = "lblApellidoHistorial";
            this.lblApellidoHistorial.Size = new System.Drawing.Size(95, 13);
            this.lblApellidoHistorial.TabIndex = 3;
            this.lblApellidoHistorial.Text = "Apellido del cliente";
            this.lblApellidoHistorial.Click += new System.EventHandler(this.lblApellidoHistorial_Click);
            // 
            // txtApellidoHistorial
            // 
            this.txtApellidoHistorial.Location = new System.Drawing.Point(112, 83);
            this.txtApellidoHistorial.Name = "txtApellidoHistorial";
            this.txtApellidoHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoHistorial.TabIndex = 2;
            this.txtApellidoHistorial.TextChanged += new System.EventHandler(this.txtApellidoHistorial_TextChanged);
            // 
            // txtNombreHistorial
            // 
            this.txtNombreHistorial.Location = new System.Drawing.Point(112, 57);
            this.txtNombreHistorial.Name = "txtNombreHistorial";
            this.txtNombreHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtNombreHistorial.TabIndex = 1;
            this.txtNombreHistorial.TextChanged += new System.EventHandler(this.txtNombreHistorial_TextChanged);
            // 
            // lblNombreHistorial
            // 
            this.lblNombreHistorial.AutoSize = true;
            this.lblNombreHistorial.Location = new System.Drawing.Point(10, 60);
            this.lblNombreHistorial.Name = "lblNombreHistorial";
            this.lblNombreHistorial.Size = new System.Drawing.Size(96, 13);
            this.lblNombreHistorial.TabIndex = 0;
            this.lblNombreHistorial.Text = "Nombre del Cliente";
            this.lblNombreHistorial.Click += new System.EventHandler(this.lblNombreHistorial_Click);
            // 
            // pnlBuscarCliente
            // 
            this.pnlBuscarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBuscarCliente.Controls.Add(this.dgvBuscarCliente);
            this.pnlBuscarCliente.Controls.Add(this.pictureBox3);
            this.pnlBuscarCliente.Controls.Add(this.txtBuscarCliente);
            this.pnlBuscarCliente.Controls.Add(this.btnEliminarCliente);
            this.pnlBuscarCliente.Controls.Add(this.btnEditarCliente);
            this.pnlBuscarCliente.Controls.Add(this.btnNuevoCliente);
            this.pnlBuscarCliente.Location = new System.Drawing.Point(458, 12);
            this.pnlBuscarCliente.Name = "pnlBuscarCliente";
            this.pnlBuscarCliente.Size = new System.Drawing.Size(291, 506);
            this.pnlBuscarCliente.TabIndex = 2;
            this.pnlBuscarCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBuscarCliente_Paint);
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(24, 113);
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.Size = new System.Drawing.Size(244, 319);
            this.dgvBuscarCliente.TabIndex = 5;
            this.dgvBuscarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarCliente_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DashBoard1.Properties.Resources.buscar;
            this.pictureBox3.Location = new System.Drawing.Point(245, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(24, 40);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(231, 20);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(193, 466);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(108, 466);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(24, 466);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.pnlBuscarCliente);
            this.Controls.Add(this.pnlHistorialCliente);
            this.Controls.Add(this.pnlClienteAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlClienteAgregar.ResumeLayout(false);
            this.pnlClienteAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarClienteAgregar)).EndInit();
            this.pnlHistorialCliente.ResumeLayout(false);
            this.pnlHistorialCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarHistorial)).EndInit();
            this.pnlBuscarCliente.ResumeLayout(false);
            this.pnlBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClienteAgregar;
        private System.Windows.Forms.PictureBox btnGuardarClienteAgregar;
        private System.Windows.Forms.RadioButton rdbSinEspecificarClienteAgregar;
        private System.Windows.Forms.RadioButton rdbMujerClienteAgregar;
        private System.Windows.Forms.RadioButton rdbHombreClienteAgregar;
        private System.Windows.Forms.Label lblGeneroClienteAgregar;
        private System.Windows.Forms.TextBox txtCedulaClienteAgregar;
        private System.Windows.Forms.Label lblCedulaClienteAgregar;
        private System.Windows.Forms.TextBox txtApellidoClienteAgregar;
        private System.Windows.Forms.Label lblApellidoClienteAgregar;
        private System.Windows.Forms.Label lblNombreClienteAgregar;
        private System.Windows.Forms.TextBox txtNombreClienteAgregar;
        private System.Windows.Forms.Label lblAgregarUnCliente;
        private System.Windows.Forms.Panel pnlHistorialCliente;
        private System.Windows.Forms.PictureBox btnBuscarHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.TextBox txtCedulaHistorial;
        private System.Windows.Forms.Label lblCedulaHistorial;
        private System.Windows.Forms.Label lblApellidoHistorial;
        private System.Windows.Forms.TextBox txtApellidoHistorial;
        private System.Windows.Forms.TextBox txtNombreHistorial;
        private System.Windows.Forms.Label lblNombreHistorial;
        private System.Windows.Forms.Label lblProvinciaClienteAgregar;
        private System.Windows.Forms.ComboBox cbbProvinciaClienteAgregar;
        private System.Windows.Forms.DataGridView dgvHistorialCliente;
        private System.Windows.Forms.Panel pnlBuscarCliente;
        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}