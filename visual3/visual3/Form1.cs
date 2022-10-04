using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Lab.rab.№1 St. gr. 10701121 Zhurovich K.S.\n";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double s = 1;
                int k = 1;
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(textBox3.Text);
                double m = Convert.ToDouble(textBox4.Text);
                double h = (x2 - x1) / n;
                richTextBox1.Text += label1.Text + " =" + textBox1.Text + "\n" + label2.Text + " = " + textBox2.Text + "\n" + label3.Text + " = " + textBox3.Text + "\n" + label4.Text + " = " + textBox4.Text + "\n";
                double t = 0;
                while (x1 <= x2)
                {
                    for(double i = 1; i <= m; i++)
                    {
                        s += sn(x1, i);
                    }
                    k += 1;
                    if (sn(x1,k)<=0.0001||k==500)
                    {
                        t = tr(x1);
                        richTextBox1.Text += "при x = " + Convert.ToString(Math.Round(x1, 5)) + "        Сумма = " + Convert.ToString(Math.Round(s, 5)) + "        Точное решение = " + Convert.ToString(Math.Round(t, 5)) + "\n";
                        x1 += h;
                        k = 1;
                        s = 1;
                    }
                }
            }
            catch
            {
                richTextBox1.Text += "Ошибка\n";
            }
        }
        private double Fac(double n)
        {
            if (n == 1) return 1;

            return n * Fac(n - 1);
        }
        private double sn(double x, double n)
        {
            return Math.Pow(x, n) * Math.Cos(n * Math.PI / 4) / Fac(n);
        }
        private double tr(double x)
        {
            return Math.Exp(x*Math.Cos(Math.PI / 4)) * Math.Cos(x * Math.Sin(Math.PI / 4));
        }

    }
}
