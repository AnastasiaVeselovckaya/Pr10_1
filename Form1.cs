using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая____10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);

            double xk = Convert.ToDouble(textBox2.Text);

            double dx = Convert.ToDouble(textBox3.Text);

            double a = Convert.ToDouble(textBox4.Text);

            double b = Convert.ToDouble(textBox5.Text);

            richTextBox1.Text = "Результат:" + Environment.NewLine;
            // Цикл для табулирования функции

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = 1.2 * Math.Pow(a - b, 3) * Math.Pow(Math.E, Math.Pow(x, 2)) + x;
                richTextBox1.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                this.chart1.Series[0].Points.AddXY(x, y);
                x = x + dx;
            }
        }
    }
}
