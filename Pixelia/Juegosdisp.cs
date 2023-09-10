using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelia
{
    public partial class Juegosdisp : Form
    {
        private string connectionString = "Data Source = (local);Initial Catalog = Pixelia; Integrated Security = SSPI"; 
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public Juegosdisp()
        {
            InitializeComponent();
           
        }

        private void Juegosdisp_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM Videojuego", connection);
            try
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void comoboxfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu men= new Menu();
            men.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboboxfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
