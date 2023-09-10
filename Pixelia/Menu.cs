using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelia
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login logmen=new Login();
            logmen.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Juegosdisp juegos = new Juegosdisp();
            juegos.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recomendacion recomendar=new recomendacion();
            recomendar.ShowDialog(); 
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = this.Tag as String;
            compras com = new compras(username);
            com.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string username = this.Tag as String;
            lblnomuser.Text= username;
        }

        private void lblnomuser_Click(object sender, EventArgs e)
        {

        }
    }
}
