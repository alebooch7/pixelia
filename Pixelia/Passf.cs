using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelia
{
    public partial class Passf : Form
    {
        public Passf()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.ShowDialog();
            this.Close();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void btnrecover_Click(object sender, EventArgs e)
        {
            string username=txtuser.Text;
            try
            {
                SqlConnection conn = Dataccess.getConnection();
                conn.Open();
                string query = "SELECT passcode FROM usuarios WHERE Nombre_user = @Username";
                SqlCommand cmd = Dataccess.getCommand(query);
                cmd.Parameters.AddWithValue("@Username", username);
                string password = (string)cmd.ExecuteScalar();

                if (!string.IsNullOrEmpty(password))
                {
                    txtpass.Text = password;
                    txtpass.Visible = true;
                }
                else
                {
                    
                    lblcontra.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }
    }
}
