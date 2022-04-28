namespace DashBoard1
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnTrabajadores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuVertical.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1460, 44);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuVertical.Controls.Add(this.btnGanancias);
            this.menuVertical.Controls.Add(this.btnProveedores);
            this.menuVertical.Controls.Add(this.btnTrabajadores);
            this.menuVertical.Controls.Add(this.btnCompras);
            this.menuVertical.Controls.Add(this.btnVentas);
            this.menuVertical.Controls.Add(this.btnProductos);
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Controls.Add(this.btnDashboard);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 44);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(233, 661);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGanancias.FlatAppearance.BorderSize = 0;
            this.btnGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancias.Location = new System.Drawing.Point(0, 449);
            this.btnGanancias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(233, 37);
            this.btnGanancias.TabIndex = 7;
            this.btnGanancias.Text = "GANANCIAS";
            this.btnGanancias.UseVisualStyleBackColor = true;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Location = new System.Drawing.Point(-4, 317);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(233, 37);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnTrabajadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajadores.Location = new System.Drawing.Point(0, 230);
            this.btnTrabajadores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Size = new System.Drawing.Size(233, 37);
            this.btnTrabajadores.TabIndex = 5;
            this.btnTrabajadores.Text = "TRABAJADORES";
            this.btnTrabajadores.UseVisualStyleBackColor = true;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Location = new System.Drawing.Point(0, 361);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(233, 37);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(-4, 405);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(233, 37);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(0, 273);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(233, 37);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(-4, 186);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(233, 37);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(0, 142);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(233, 37);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.lblWelcome);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(233, 44);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1227, 661);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(139, 273);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(841, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "¡Bienvenid@ a nuestro entorno de trabajo!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 705);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.menuVertical.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnTrabajadores;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Label lblWelcome;
    }
}

