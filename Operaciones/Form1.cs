using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            double b, h;
            b = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);
            total = (b * h) / 2;
            MessageBox.Show("El área es: " + total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double per;
            double l;
            l = double.Parse(textBox3.Text);
            per = 3 * l;
            MessageBox.Show("El perímetro es: " + per);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double vol;
            double r, h;
            r = double.Parse(textBox6.Text);
            h = double.Parse(textBox5.Text);
            vol = (Math.PI * (r * r) * h) / 3;
            MessageBox.Show("El volumen es: " + vol);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double area;
            double b, h;
            b = double.Parse(textBox8.Text);
            h = double.Parse(textBox7.Text);
            area = b * h;
            MessageBox.Show("El área es: " + area + " _201503529");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double per;
            double b, h;
            b = double.Parse(textBox8.Text);
            h = double.Parse(textBox7.Text);
            per = (2 * h) + (2 * b);
            MessageBox.Show("El perímetro es: " + per + " _201503529");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double area;
            double b, h, p;
            b = double.Parse(textBox9.Text);
            h = double.Parse(textBox4.Text);
            p = double.Parse(textBox10.Text);
            area = 2 * ((b * p) + (b * h) + (p * h));
            MessageBox.Show("El área es: " + area);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double vol;
            double b, h, p;
            b = double.Parse(textBox9.Text);
            h = double.Parse(textBox4.Text);
            p = double.Parse(textBox10.Text);
            vol = b * h * p;
            MessageBox.Show("El volumen es: " + vol);
        }
    }
}
