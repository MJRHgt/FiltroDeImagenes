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
        Bitmap medio;
        //posiciones matriz
        int a, b, c, d, e1, f, g, h, i;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtener valores de los texbox
            a = int.Parse(m_1.Text);
            b = int.Parse(m_2.Text);
            c = int.Parse(m_3.Text);
            d = int.Parse(m_4.Text);
            e1 = int.Parse(m_5.Text);
            f = int.Parse(m_6.Text);
            g = int.Parse(m_7.Text);
            h = int.Parse(m_8.Text);
            i = int.Parse(m_9.Text);

            //mapeo de nueva matriz para motrar al final
            Bitmap final = new Bitmap(medio.Width, medio.Height);//definir x,y
            int ancho = medio.Width - 1;
            int altura = medio.Height - 1;
            //recorre la matriz
            for (int i = 1; i < ancho; i++)
            {

                for (int j = 1; j < altura; j++)
                {
                    Color posicion1, posicion2, posicion3, posicion4, posicion5, posicion6, posicion7, posicion8, posicion9;
                    posicion1 = medio.GetPixel(i-1,j-1);
                    posicion2 = medio.GetPixel(i,j-1);
                    posicion3 = medio.GetPixel(i+1,j-1);
                    posicion4 = medio.GetPixel(i-1,j);
                    posicion5 = medio.GetPixel(i,j);
                    posicion6 = medio.GetPixel(i+1,j);
                    posicion7 = medio.GetPixel(i-1, j+1);
                    posicion8 = medio.GetPixel(i,j+1);
                    posicion9 = medio.GetPixel(i+1,j+1);
                    //operacion


                    //cambiar colores
                    int fila1 = posicion1.R+ posicion2.R + posicion4.R + posicion5.R  + posicion6.R + posicion8.R;
                    int fila2 = posicion2.G + posicion4.G + posicion5.G * (4) + posicion6.G + posicion8.G;
                    int fila3 = posicion2.B + posicion4.B + posicion5.B * (4) + posicion6.B + posicion8.B;
                    //validar colores
                    int avr = ((fila1 + fila2 + fila3) / 3);
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
            int c = 0;
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
            int num1 = 1;
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
