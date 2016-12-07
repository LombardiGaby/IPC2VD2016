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
    }
}
