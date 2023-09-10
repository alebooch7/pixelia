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
    public partial class factura : Form
    {
        string cadenaConexion = "Data Source = (local);Initial Catalog = Pixelia; Integrated Security = SSPI";
        public factura(string nombreJuego, double precioJuego, int idCliente)
        {
            InitializeComponent();

            // Establece el nombre del juego en el TextBox correspondiente
            txtNombreJuego.Text = nombreJuego;

            // Establece el precio del juego en el TextBox txtTotal
            txttotal.Text = precioJuego.ToString("N2");

            txtidCliente.Text = idCliente.ToString();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Consulta SQL para obtener el último número de factura
                string consulta = "SELECT MAX(num_factura) FROM Facturas";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        // Obtener el último número de factura y agregar 1 para obtener el próximo número
                        int ultimoNumeroFactura = Convert.ToInt32(resultado);
                        int proximoNumeroFactura = ultimoNumeroFactura + 1;

                        // Mostrar el próximo número en el TextBox txtfactura
                        txtfactura.Text = proximoNumeroFactura.ToString();
                    }
                    else
                    {
                        // Si no hay registros en la tabla Facturas, establecer el número inicial
                        txtfactura.Text = "1";
                    }
                }

                conexion.Close();
            }
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy/MM/dd");
            txtFecha.Text = fechaFormateada;

        }

        private void factura_Load(object sender, EventArgs e)
        {
            


        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtiva_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularIVA_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txttotal.Text, out double precio))
            {
                double iva = precio * 0.12; // 12% de IVA
                txtiva.Text = iva.ToString("N2"); // Muestra el IVA con dos decimales
                double total = precio + iva;
                txttotal.Text = total.ToString("N2"); // Muestra el total con dos decimales
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos del formulario factura
            string numeroFactura = txtfactura.Text;
            double total = Convert.ToDouble(txttotal.Text);
            double iva = Convert.ToDouble(txtiva.Text);
            string fechaFactura = txtFecha.Text;
            int idCliente = Convert.ToInt32(txtidCliente.Text); // Asegúrate de tener el TextBox correcto para el ID del cliente

            // Establecer una cadena de conexión a la base de datos
            string cadenaConexion = "Data Source=(local);Initial Catalog=Pixelia;Integrated Security=SSPI";

            // Crear una consulta SQL para insertar los datos en la tabla Facturas
            string consulta = "INSERT INTO Facturas (num_factura, total, iva, fecha_fact, id_cliente) " +
                             "VALUES (@NumeroFactura, @Total, @IVA, @FechaFactura, @IDCliente)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    // Asignar los valores a los parámetros de la consulta
                    comando.Parameters.AddWithValue("@NumeroFactura", numeroFactura);
                    comando.Parameters.AddWithValue("@Total", total);
                    comando.Parameters.AddWithValue("@IVA", iva);
                    comando.Parameters.AddWithValue("@FechaFactura", fechaFactura);
                    comando.Parameters.AddWithValue("@IDCliente", idCliente);

                    // Ejecutar la consulta para agregar la factura a la base de datos
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Compra exitosa. Los datos se han agregado a la base de datos.", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la factura a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conexion.Close();
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            string username = this.Tag as String;
            compras com = new compras(username);
            com.ShowDialog();

            
            
        }
    }
}
