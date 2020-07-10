using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace ProyectoImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //usar bitmap
        Bitmap medio = null;
        public TextWriter wpath;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap final = new Bitmap(medio.Width, medio.Height);//definir x,y
            int ancho = medio.Width - 1, altura = medio.Height - 1;
            //recorre la matriz
            for (int i = 0; i < ancho; i++)
            {

                for (int j = 0; j < altura; j++)
                {
                    Color color2, color4, color5, color6, color8;
                    color2 = medio.GetPixel(i,j-1);
                    color4 = medio.GetPixel(i-1,j);
                    color5 = medio.GetPixel(i,j);
                    color6 = medio.GetPixel(i+1,j);
                    color8 = medio.GetPixel(i,j+1);
                    //cambiar colores
                    int colorrojo = color2.R + color4.R + color5.R * (-4) + color6.R + color8.R;
                    int colorverde = color2.G + color4.G + color5.G * (-4) + color6.G + color8.G;
                    int colorazul = color2.B + color4.B + color5.B * (-4) + color6.B + color8.B;
                    //validar colores
                    int avr = ((colorrojo + colorverde + colorazul) / 3);
                    if (avr>255)
                    {
                        avr = 255;
                    }
                    if (avr<0)
                    {
                        avr = 0;
                    }
                    //regresar
                    final.SetPixel(i,j,Color.FromArgb(avr,avr,avr));

                }

            }//fin de la matriz
            pictureBox2.Image = final;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            var resultado = d.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            var filename = d.FileName;
            var image = Image.FromFile(filename);
            pictureBox1.Image = image;

            string name = Path.GetFileName(d.FileName);

           path.Text = name.ToString();

            //usar bitmap
            medio = (Bitmap)Bitmap.FromFile(d.FileName);
            pictureBox1.Image = medio;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Met1_Click(object sender, EventArgs e)
        {
            double num1 = 1;
            m_1.Text = num1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void metodo_2_Click(object sender, EventArgs e)
        {

        }
    }
}
