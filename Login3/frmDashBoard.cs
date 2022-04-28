using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard1
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void horaYFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblGananciasDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pnlGananciasDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDineroDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblGananciasSubtittleDashboard_Click(object sender, EventArgs e)
        {

        }

        private void imgGananciasDashboard_Click(object sender, EventArgs e)
        {

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void lblVentasDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroVentasDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblVentasSubtittleDashboard_Click(object sender, EventArgs e)
        {

        }

        private void imbVentasDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void pnlHoraDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarDashboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlProgresoDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgCirclebarDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblProgresoDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pnlValorDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgBolsaDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblValorDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
