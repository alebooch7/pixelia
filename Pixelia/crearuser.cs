using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelia
{
    public partial class crearuser : Form
    {
        public crearuser()
        {
            InitializeComponent();
        }

        private void crearuser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Login paglogin = new Login();
            paglogin.ShowDialog();
            this.Close();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;
            SqlConnection conn = null;
            try
            {
                conn = Dataccess.getConnection();
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE Nombre_user = @Username";
                SqlCommand checkCmd = Dataccess.getCommand(checkQuery);
                checkCmd.Parameters.AddWithValue("@Username", username);
                int userCount = (int)checkCmd.ExecuteScalar();
                if (userCount > 0)
                {
                    lblExist.Visible = true;
                    lblusecreado.Visible=false;
                    return;
                }
                string insertQuery = "INSERT INTO usuarios (Nombre_user, passcode) VALUES (@Username, @Password)";
                SqlCommand cmd = Dataccess.getCommand(insertQuery);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    lblExist.Visible = false;
                    lblusecreado.Visible = true;
                }
                else
                {
                    MessageBox.Show("error al registrar el usuario");
                }

                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:"+ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Login paglogin = new Login();
            paglogin.ShowDialog();
            this.Close();
        }
    }
    }

