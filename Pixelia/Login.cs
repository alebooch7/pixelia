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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace Pixelia
{
    public partial class Login : Form
    {
        public string userRecibido { get; set; }
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username=txtuser.Text;
            string password=txtpass.Text;
            SqlConnection conn=null;
            try
            {
                conn = Dataccess.getConnection();
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE Nombre_user = @Username AND passcode = @Password";
                SqlCommand cmd = Dataccess.getCommand(query);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count=(int)cmd.ExecuteScalar();
                if(count > 0 )
                {
                    
                    MessageBox.Show("inicio de sesion exitoso");
                    
                    Menu menu = new Menu();
                    menu.Tag = username;
                    menu.ShowDialog();
                    this.Close();

                    compras name = new compras(username);
                    
                }
                else
                {
                    MessageBox.Show("el usuario no existe o la contraseña es incorrecta ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                
            }
        }

        private void Crearcuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            crearuser crear=new crearuser();
            crear.ShowDialog();
            this.Close();
        }

        private void passf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Passf recover = new Passf();
            recover.ShowDialog();   
            this.Close();


        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;

            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
