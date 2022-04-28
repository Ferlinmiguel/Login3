namespace DashBoard1
{
    partial class frmDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.txtBuscarDashboard = new System.Windows.Forms.TextBox();
            this.pnlGananciasDashboard = new System.Windows.Forms.Panel();
            this.lblGananciasSubtittleDashboard = new System.Windows.Forms.Label();
            this.imgGananciasDashboard = new System.Windows.Forms.PictureBox();
            this.lblDineroDashboard = new System.Windows.Forms.Label();
            this.lblGananciasDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imbVentasDashboard = new System.Windows.Forms.PictureBox();
            this.lblVentasSubtittleDashboard = new System.Windows.Forms.Label();
            this.lblNumeroVentasDashboard = new System.Windows.Forms.Label();
            this.lblVentasDashboard = new System.Windows.Forms.Label();
            this.pnlHoraDashboard = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaYFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlProgresoDashboard = new System.Windows.Forms.Panel();
            this.imgCirclebarDashboard = new System.Windows.Forms.PictureBox();
            this.lblProgresoDashboard = new System.Windows.Forms.Label();
            this.pnlValorDashboard = new System.Windows.Forms.Panel();
            this.imgBolsaDashboard = new System.Windows.Forms.PictureBox();
            this.lblValorDashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGananciasDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGananciasDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbVentasDashboard)).BeginInit();
            this.pnlHoraDashboard.SuspendLayout();
            this.pnlProgresoDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCirclebarDashboard)).BeginInit();
            this.pnlValorDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBolsaDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(147, 31);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // txtBuscarDashboard
            // 
            this.txtBuscarDashboard.Location = new System.Drawing.Point(732, 20);
            this.txtBuscarDashboard.Name = "txtBuscarDashboard";
            this.txtBuscarDashboard.Size = new System.Drawing.Size(214, 20);
            this.txtBuscarDashboard.TabIndex = 1;
            this.txtBuscarDashboard.TextChanged += new System.EventHandler(this.txtBuscarDashboard_TextChanged);
            // 
            // pnlGananciasDashboard
            // 
            this.pnlGananciasDashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlGananciasDashboard.Controls.Add(this.lblGananciasSubtittleDashboard);
            this.pnlGananciasDashboard.Controls.Add(this.imgGananciasDashboard);
            this.pnlGananciasDashboard.Controls.Add(this.lblDineroDashboard);
            this.pnlGananciasDashboard.Controls.Add(this.lblGananciasDashboard);
            this.pnlGananciasDashboard.Location = new System.Drawing.Point(30, 87);
            this.pnlGananciasDashboard.Name = "pnlGananciasDashboard";
            this.pnlGananciasDashboard.Size = new System.Drawing.Size(285, 114);
            this.pnlGananciasDashboard.TabIndex = 3;
            this.pnlGananciasDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGananciasDashboard_Paint);
            // 
            // lblGananciasSubtittleDashboard
            // 
            this.lblGananciasSubtittleDashboard.AutoSize = true;
            this.lblGananciasSubtittleDashboard.Location = new System.Drawing.Point(8, 82);
            this.lblGananciasSubtittleDashboard.Name = "lblGananciasSubtittleDashboard";
            this.lblGananciasSubtittleDashboard.Size = new System.Drawing.Size(163, 13);
            this.lblGananciasSubtittleDashboard.TabIndex = 5;
            this.lblGananciasSubtittleDashboard.Text = "Ganancias de los últimos 26 días";
            this.lblGananciasSubtittleDashboard.Click += new System.EventHandler(this.lblGananciasSubtittleDashboard_Click);
            // 
            // imgGananciasDashboard
            // 
            this.imgGananciasDashboard.Image = global::DashBoard1.Properties.Resources.ganancias;
            this.imgGananciasDashboard.Location = new System.Drawing.Point(177, 10);
            this.imgGananciasDashboard.Name = "imgGananciasDashboard";
            this.imgGananciasDashboard.Size = new System.Drawing.Size(108, 90);
            this.imgGananciasDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGananciasDashboard.TabIndex = 4;
            this.imgGananciasDashboard.TabStop = false;
            this.imgGananciasDashboard.Click += new System.EventHandler(this.imgGananciasDashboard_Click);
            // 
            // lblDineroDashboard
            // 
            this.lblDineroDashboard.AutoSize = true;
            this.lblDineroDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDineroDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDineroDashboard.Location = new System.Drawing.Point(6, 39);
            this.lblDineroDashboard.Name = "lblDineroDashboard";
            this.lblDineroDashboard.Size = new System.Drawing.Size(137, 29);
            this.lblDineroDashboard.TabIndex = 1;
            this.lblDineroDashboard.Text = "RD$ 50,000";
            this.lblDineroDashboard.Click += new System.EventHandler(this.lblDineroDashboard_Click);
            // 
            // lblGananciasDashboard
            // 
            this.lblGananciasDashboard.AutoSize = true;
            this.lblGananciasDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasDashboard.Location = new System.Drawing.Point(4, 4);
            this.lblGananciasDashboard.Name = "lblGananciasDashboard";
            this.lblGananciasDashboard.Size = new System.Drawing.Size(99, 24);
            this.lblGananciasDashboard.TabIndex = 0;
            this.lblGananciasDashboard.Text = "Ganancias";
            this.lblGananciasDashboard.Click += new System.EventHandler(this.lblGananciasDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.imbVentasDashboard);
            this.panel2.Controls.Add(this.lblVentasSubtittleDashboard);
            this.panel2.Controls.Add(this.lblNumeroVentasDashboard);
            this.panel2.Controls.Add(this.lblVentasDashboard);
            this.panel2.Location = new System.Drawing.Point(361, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 114);
            this.panel2.TabIndex = 4;
            // 
            // imbVentasDashboard
            // 
            this.imbVentasDashboard.Image = global::DashBoard1.Properties.Resources.stock;
            this.imbVentasDashboard.Location = new System.Drawing.Point(177, 10);
            this.imbVentasDashboard.Name = "imbVentasDashboard";
            this.imbVentasDashboard.Size = new System.Drawing.Size(108, 90);
            this.imbVentasDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imbVentasDashboard.TabIndex = 3;
            this.imbVentasDashboard.TabStop = false;
            this.imbVentasDashboard.Click += new System.EventHandler(this.imbVentasDashboard_Click);
            // 
            // lblVentasSubtittleDashboard
            // 
            this.lblVentasSubtittleDashboard.AutoSize = true;
            this.lblVentasSubtittleDashboard.Location = new System.Drawing.Point(8, 82);
            this.lblVentasSubtittleDashboard.Name = "lblVentasSubtittleDashboard";
            this.lblVentasSubtittleDashboard.Size = new System.Drawing.Size(131, 13);
            this.lblVentasSubtittleDashboard.TabIndex = 2;
            this.lblVentasSubtittleDashboard.Text = "De los productos en stock";
            this.lblVentasSubtittleDashboard.Click += new System.EventHandler(this.lblVentasSubtittleDashboard_Click);
            // 
            // lblNumeroVentasDashboard
            // 
            this.lblNumeroVentasDashboard.AutoSize = true;
            this.lblNumeroVentasDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVentasDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumeroVentasDashboard.Location = new System.Drawing.Point(6, 39);
            this.lblNumeroVentasDashboard.Name = "lblNumeroVentasDashboard";
            this.lblNumeroVentasDashboard.Size = new System.Drawing.Size(98, 29);
            this.lblNumeroVentasDashboard.TabIndex = 1;
            this.lblNumeroVentasDashboard.Text = "450/500";
            this.lblNumeroVentasDashboard.Click += new System.EventHandler(this.lblNumeroVentasDashboard_Click);
            // 
            // lblVentasDashboard
            // 
            this.lblVentasDashboard.AutoSize = true;
            this.lblVentasDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasDashboard.Location = new System.Drawing.Point(4, 4);
            this.lblVentasDashboard.Name = "lblVentasDashboard";
            this.lblVentasDashboard.Size = new System.Drawing.Size(68, 24);
            this.lblVentasDashboard.TabIndex = 0;
            this.lblVentasDashboard.Text = "Ventas";
            this.lblVentasDashboard.Click += new System.EventHandler(this.lblVentasDashboard_Click);
            // 
            // pnlHoraDashboard
            // 
            this.pnlHoraDashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlHoraDashboard.Controls.Add(this.lblFecha);
            this.pnlHoraDashboard.Controls.Add(this.lblHora);
            this.pnlHoraDashboard.Location = new System.Drawing.Point(692, 87);
            this.pnlHoraDashboard.Name = "pnlHoraDashboard";
            this.pnlHoraDashboard.Size = new System.Drawing.Size(285, 114);
            this.pnlHoraDashboard.TabIndex = 5;
            this.pnlHoraDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHoraDashboard_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(17, 73);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label9";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(9, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(152, 55);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label8";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // horaYFecha
            // 
            this.horaYFecha.Enabled = true;
            this.horaYFecha.Tick += new System.EventHandler(this.horaYFecha_Tick);
            // 
            // pnlProgresoDashboard
            // 
            this.pnlProgresoDashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlProgresoDashboard.Controls.Add(this.imgCirclebarDashboard);
            this.pnlProgresoDashboard.Controls.Add(this.lblProgresoDashboard);
            this.pnlProgresoDashboard.Location = new System.Drawing.Point(30, 238);
            this.pnlProgresoDashboard.Name = "pnlProgresoDashboard";
            this.pnlProgresoDashboard.Size = new System.Drawing.Size(285, 237);
            this.pnlProgresoDashboard.TabIndex = 6;
            this.pnlProgresoDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProgresoDashboard_Paint);
            // 
            // imgCirclebarDashboard
            // 
            this.imgCirclebarDashboard.Image = global::DashBoard1.Properties.Resources.bar;
            this.imgCirclebarDashboard.Location = new System.Drawing.Point(11, 36);
            this.imgCirclebarDashboard.Name = "imgCirclebarDashboard";
            this.imgCirclebarDashboard.Size = new System.Drawing.Size(259, 190);
            this.imgCirclebarDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCirclebarDashboard.TabIndex = 1;
            this.imgCirclebarDashboard.TabStop = false;
            this.imgCirclebarDashboard.Click += new System.EventHandler(this.imgCirclebarDashboard_Click);
            // 
            // lblProgresoDashboard
            // 
            this.lblProgresoDashboard.AutoSize = true;
            this.lblProgresoDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresoDashboard.Location = new System.Drawing.Point(4, 9);
            this.lblProgresoDashboard.Name = "lblProgresoDashboard";
            this.lblProgresoDashboard.Size = new System.Drawing.Size(245, 24);
            this.lblProgresoDashboard.TabIndex = 0;
            this.lblProgresoDashboard.Text = "Progreso en ventas del mes";
            this.lblProgresoDashboard.Click += new System.EventHandler(this.lblProgresoDashboard_Click);
            // 
            // pnlValorDashboard
            // 
            this.pnlValorDashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlValorDashboard.Controls.Add(this.imgBolsaDashboard);
            this.pnlValorDashboard.Controls.Add(this.lblValorDashboard);
            this.pnlValorDashboard.Location = new System.Drawing.Point(357, 239);
            this.pnlValorDashboard.Name = "pnlValorDashboard";
            this.pnlValorDashboard.Size = new System.Drawing.Size(620, 236);
            this.pnlValorDashboard.TabIndex = 7;
            this.pnlValorDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlValorDashboard_Paint);
            // 
            // imgBolsaDashboard
            // 
            this.imgBolsaDashboard.Image = global::DashBoard1.Properties.Resources.graficooo;
            this.imgBolsaDashboard.Location = new System.Drawing.Point(4, 35);
            this.imgBolsaDashboard.Name = "imgBolsaDashboard";
            this.imgBolsaDashboard.Size = new System.Drawing.Size(613, 198);
            this.imgBolsaDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBolsaDashboard.TabIndex = 1;
            this.imgBolsaDashboard.TabStop = false;
            this.imgBolsaDashboard.Click += new System.EventHandler(this.imgBolsaDashboard_Click);
            // 
            // lblValorDashboard
            // 
            this.lblValorDashboard.AutoSize = true;
            this.lblValorDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDashboard.Location = new System.Drawing.Point(15, 8);
            this.lblValorDashboard.Name = "lblValorDashboard";
            this.lblValorDashboard.Size = new System.Drawing.Size(256, 24);
            this.lblValorDashboard.TabIndex = 0;
            this.lblValorDashboard.Text = "Valor en bolsa de la empresa";
            this.lblValorDashboard.Click += new System.EventHandler(this.lblValorDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashBoard1.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(952, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.pnlValorDashboard);
            this.Controls.Add(this.pnlProgresoDashboard);
            this.Controls.Add(this.pnlHoraDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlGananciasDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarDashboard);
            this.Controls.Add(this.lblDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnlGananciasDashboard.ResumeLayout(false);
            this.pnlGananciasDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGananciasDashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbVentasDashboard)).EndInit();
            this.pnlHoraDashboard.ResumeLayout(false);
            this.pnlHoraDashboard.PerformLayout();
            this.pnlProgresoDashboard.ResumeLayout(false);
            this.pnlProgresoDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCirclebarDashboard)).EndInit();
            this.pnlValorDashboard.ResumeLayout(false);
            this.pnlValorDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBolsaDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.TextBox txtBuscarDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlGananciasDashboard;
        private System.Windows.Forms.PictureBox imgGananciasDashboard;
        private System.Windows.Forms.Label lblDineroDashboard;
        private System.Windows.Forms.Label lblGananciasDashboard;
        private System.Windows.Forms.Label lblGananciasSubtittleDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumeroVentasDashboard;
        private System.Windows.Forms.Label lblVentasDashboard;
        private System.Windows.Forms.PictureBox imbVentasDashboard;
        private System.Windows.Forms.Label lblVentasSubtittleDashboard;
        private System.Windows.Forms.Panel pnlHoraDashboard;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaYFecha;
        private System.Windows.Forms.Panel pnlProgresoDashboard;
        private System.Windows.Forms.PictureBox imgCirclebarDashboard;
        private System.Windows.Forms.Label lblProgresoDashboard;
        private System.Windows.Forms.Panel pnlValorDashboard;
        private System.Windows.Forms.PictureBox imgBolsaDashboard;
        private System.Windows.Forms.Label lblValorDashboard;
    }
}