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
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //posiciones matriz
            double a, b, c, d, e1, f, g, h, i1;
            //obtener valores de los texbox
            a = double.Parse(m_1.Text);
            b = double.Parse(m_2.Text);
            c = double.Parse(m_3.Text);
            d = double.Parse(m_4.Text);
            e1 = double.Parse(m_5.Text);
            f = double.Parse(m_6.Text);
            g = double.Parse(m_7.Text);
            h = double.Parse(m_8.Text);
            i1 = double.Parse(m_9.Text);
            //si es null, asumimos que ingreso 0
            //mapeo de nueva matriz para motrar al final
            Bitmap final = new Bitmap(medio.Width, medio.Height);//definir x,y
            double ancho = medio.Width - 1;
            double altura = medio.Height - 1;

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
                    double fila1 = (posicion1.R*a) + (posicion2.R*d) + (posicion3.R*g) + (posicion4.R*b) + (posicion5.R*e1) + (posicion6.R*h) + (posicion7.R*c) + (posicion8.R*f) + (posicion9.R*i1) ;
                    double fila2 = (posicion1.G * a) + (posicion2.G * d) + (posicion3.G * g) + (posicion4.G * b) + (posicion5.G * e1) + (posicion6.G * h) + (posicion7.G * c) + (posicion8.G * f) + (posicion9.G * i1);
                    double fila3 = (posicion1.B*a) + (posicion2.B*d) + (posicion3.B*g) + (posicion4.B*b) + (posicion5.B*e1) + (posicion6.B*h) + (posicion7.B*c) + (posicion8.B*f) + (posicion9.B*i1) ;
                    //validar colores
                    int ffila1 = Convert.ToInt32(fila1);
                    int ffila2 = Convert.ToInt32(fila2);
                    int ffila3 = Convert.ToInt32(fila3);
                    //evitar que se salgan del rango
                    int avr = ((ffila1 + ffila2 + ffila3) / 3);
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

            MessageBox.Show("Todo sucedio de manera correcta");
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
            double num1 = 0.0625;
            m_1.Text = num1.ToString();

            double num2 = 0.125;
            m_2.Text = num2.ToString();

            double num3 = 0.0625;
            m_3.Text = num3.ToString();

            double num4 = 0.125;
            m_4.Text = num4.ToString();

            double num5 = 0.25;
            m_5.Text = num5.ToString();

            double num6 = 0.125;
            m_6.Text = num6.ToString();

            double num7 = 0.0625;
            m_7.Text = num7.ToString();

            double num8 = 0.125;
            m_8.Text = num8.ToString();

            double num9 = 0.0625;
            m_9.Text = num9.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = -1;
            m_1.Text = num1.ToString();

            double num2 = -1;
            m_2.Text = num2.ToString();

            double num3 = -1;
            m_3.Text = num3.ToString();

            double num4 = -1;
            m_4.Text = num4.ToString();

            double num5 = 8;
            m_5.Text = num5.ToString();

            double num6 = -1;
            m_6.Text = num6.ToString();

            double num7 = -1;
            m_7.Text = num7.ToString();

            double num8 = -1;
            m_8.Text = num8.ToString();

            double num9 = -1;
            m_9.Text = num9.ToString();
        }

        private void metodo_2_Click(object sender, EventArgs e)
        {
            double num1 = -2;
            m_1.Text = num1.ToString();

            double num2 = -1;
            m_2.Text = num2.ToString();

            double num3 = 0;
            m_3.Text = num3.ToString();

            double num4 = -1;
            m_4.Text = num4.ToString();

            double num5 = 1;
            m_5.Text = num5.ToString();

            double num6 = 1;
            m_6.Text = num6.ToString();

            double num7 = 0;
            m_7.Text = num7.ToString();

            double num8 = 1;
            m_8.Text = num8.ToString();

            double num9 = 2;
            m_9.Text = num9.ToString();
        }

        private void metodo_3_Click(object sender, EventArgs e)
        {
            double num1 = -1;
            m_1.Text = num1.ToString();

            double num2 = -0;
            m_2.Text = num2.ToString();

            double num3 = 1;
            m_3.Text = num3.ToString();

            double num4 = -2;
            m_4.Text = num4.ToString();

            double num5 = 0;
            m_5.Text = num5.ToString();

            double num6 = 2;
            m_6.Text = num6.ToString();

            double num7 = -1;
            m_7.Text = num7.ToString();

            double num8 = 0;
            m_8.Text = num8.ToString();

            double num9 = 1;
            m_9.Text = num9.ToString();
        }

        private void metodo_4_Click(object sender, EventArgs e)
        {
            double num1 = 1;
            m_1.Text = num1.ToString();

            double num2 = 0;
            m_2.Text = num2.ToString();

            double num3 = -1;
            m_3.Text = num3.ToString();

            double num4 = 2;
            m_4.Text = num4.ToString();

            double num5 = 0;
            m_5.Text = num5.ToString();

            double num6 = -2;
            m_6.Text = num6.ToString();

            double num7 = 1;
            m_7.Text = num7.ToString();

            double num8 = 0;
            m_8.Text = num8.ToString();

            double num9 = -1;
            m_9.Text = num9.ToString();
        }

        private void metodo_5_Click(object sender, EventArgs e)
        {
            double num1 = 1;
            m_1.Text = num1.ToString();

            double num2 = 2;
            m_2.Text = num2.ToString();

            double num3 = 1;
            m_3.Text = num3.ToString();

            double num4 = 0;
            m_4.Text = num4.ToString();

            double num5 = 0;
            m_5.Text = num5.ToString();

            double num6 = 0;
            m_6.Text = num6.ToString();

            double num7 = -1;
            m_7.Text = num7.ToString();

            double num8 = -2;
            m_8.Text = num8.ToString();

            double num9 = -1;
            m_9.Text = num9.ToString();
        }

        private void metodo_6_Click(object sender, EventArgs e)
        {
            double num1 = -1;
            m_1.Text = num1.ToString();

            double num2 = -2;
            m_2.Text = num2.ToString();

            double num3 = -1;
            m_3.Text = num3.ToString();

            double num4 = 0;
            m_4.Text = num4.ToString();

            double num5 = 0;
            m_5.Text = num5.ToString();

            double num6 = 0;
            m_6.Text = num6.ToString();

            double num7 = 1;
            m_7.Text = num7.ToString();

            double num8 = 2;
            m_8.Text = num8.ToString();

            double num9 = 1;
            m_9.Text = num9.ToString();
        }

        private void metodo_8_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            m_1.Text = num1.ToString();

            double num2 = -1;
            m_2.Text = num2.ToString();

            double num3 = 0;
            m_3.Text = num3.ToString();

            double num4 = -1;
            m_4.Text = num4.ToString();

            double num5 = 5;
            m_5.Text = num5.ToString();

            double num6 = -1;
            m_6.Text = num6.ToString();

            double num7 = 0;
            m_7.Text = num7.ToString();

            double num8 = -1;
            m_8.Text = num8.ToString();

            double num9 = 0;
            m_9.Text = num9.ToString();
        }

        private void metodo_9_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            m_1.Text = num1.ToString();

            double num2 = 0;
            m_2.Text = num2.ToString();

            double num3 = 0;
            m_3.Text = num3.ToString();

            double num4 = 0;
            m_4.Text = num4.ToString();

            double num5 = 1;
            m_5.Text = num5.ToString();

            double num6 = 0;
            m_6.Text = num6.ToString();

            double num7 = 0;
            m_7.Text = num7.ToString();

            double num8 = 0;
            m_8.Text = num8.ToString();

            double num9 = 0;
            m_9.Text = num9.ToString();
        }
    }
}
