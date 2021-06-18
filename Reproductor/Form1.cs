using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Reproductor : Form
    {
        public Reproductor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INGRESA la direccion en la que esta guardada el video que deseas reproducir.\n" +
                "                       NOTA TU ARCHIVO DEBE SER MP4!!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=@textBox1.Text;
        }
    }
}
