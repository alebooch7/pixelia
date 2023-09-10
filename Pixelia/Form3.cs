using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelia
{
    public partial class compras : Form
    {
        private string username;
        // Declarar la cadena de conexión a tu base de datos
        string cadenaConexion = "Data Source = (local);Initial Catalog = Pixelia; Integrated Security = SSPI";

        public compras(string username)
        {
            InitializeComponent();
            this.username = username; // Asignar el valor del parámetro al campo username de la clase
        }


        private void compras_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show(this);
            this.Close();
        }
        private int ObtenerID()
        {
            int idCliente = -1; // Valor predeterminado en caso de que no se encuentre un resultado

            // Verifica que username no sea nulo o vacío antes de continuar
            if (!string.IsNullOrEmpty(this.username))
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Crear una consulta SQL para buscar el id_cliente por nombre de usuario
                    string consulta = "SELECT id_cliente FROM Clientes WHERE Nombre_user = @Username";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Username", this.username); // Usar el campo username de la clase

                        // Ejecutar la consulta y obtener el resultado
                        object resultado = comando.ExecuteScalar();

                        // Verificar si se encontró un resultado
                        if (resultado != null && resultado != DBNull.Value)
                        {
                            idCliente = Convert.ToInt32(resultado);
                        }
                    }

                    conexion.Close();
                }
            }

            return idCliente; // Devolver el valor del id_cliente (o -1 si no se encontró)
        }



        private double ObtenerPrecioDelJuegoDesdeBD(string nombreJuego)
        {
            double precioJuego = 0; // Inicializa el precio en cero

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Crear una consulta SQL para buscar el precio del juego por nombre
                string consulta = "SELECT precio FROM Videojuego WHERE nombre = @NombreJuego";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreJuego", nombreJuego);

                    // Ejecutar la consulta y obtener el resultado
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        precioJuego = Convert.ToDouble(resultado);
                    }
                }

                conexion.Close();
            }

            return precioJuego;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreJuego = txtNombreJuego.Text;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Crear una consulta SQL para buscar el precio del juego por nombre
                string consulta = "SELECT precio FROM Videojuego WHERE nombre = @NombreJuego";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreJuego", nombreJuego);

                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encontró el juego, mostrar el precio en lblprecio
                        lblprecio.Text = "Precio: " + reader["Precio"].ToString();
                    }
                    else
                    {
                        // Si no se encontró el juego, mostrar un mensaje de error
                        lblprecio.Text = "Juego no encontrado";
                    }

                    reader.Close();
                }

                conexion.Close();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            {
                string nombreJuego = txtNombreJuego.Text;

                // Aquí debes realizar una consulta a la base de datos para obtener el precio del juego
                double precioJuego = ObtenerPrecioDelJuegoDesdeBD(nombreJuego);

                int idCliente = ObtenerID();


                if (precioJuego > 0)
                {
                    // Crea una instancia del formulario "factura" y pásale el nombre y precio del juego
                    this.Close();
                    factura facturaForm = new factura (nombreJuego, precioJuego, idCliente);

                    // Muestra el formulario "factura"
                    facturaForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("El juego no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        
         }  }
    }
}
