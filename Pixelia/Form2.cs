using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pixelia
{
    public partial class recomendacion : Form
    {
        public recomendacion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rutaImagen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recomendados", "GTAV.JPEG");
            string rutaImagen2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recomendados", "LOL.JPG");
            string rutaImagen3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recomendados", "ELDEN.JPEG");

            // Verificar si el archivo de imagen existe antes de cargarlo
            if (File.Exists(rutaImagen))
            {
                ptbjuego1.Image = Image.FromFile(rutaImagen);
                ptbjuego1.SizeMode = PictureBoxSizeMode.Zoom; // Escalar la imagen para que se ajuste al PictureBox
                ptbImagen2.Image = Image.FromFile(rutaImagen2);
                ptbImagen2.SizeMode = PictureBoxSizeMode.Zoom; // Escalar la imagen para que se ajuste al PictureBox
                ptbImagen3.Image = Image.FromFile(rutaImagen3);
                ptbImagen3.SizeMode = PictureBoxSizeMode.Zoom; // Escalar la imagen para que se ajuste al PictureBox


            }
            else
            {
                MessageBox.Show("La imagen no se encontró en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void ptbjuego1_Click(object sender, EventArgs e)
        {

        }
    }
}
