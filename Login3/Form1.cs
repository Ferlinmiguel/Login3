using System.Data.SqlClient;
using System.Configuration;
namespace Login3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("Select * From TBL_USUARIO WHERE USUARIOS = " + "'" + txtuser.Text + "'and UCLAVE= " + "'" + txtpass.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Acceso completado");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logins();
        }
    }
}