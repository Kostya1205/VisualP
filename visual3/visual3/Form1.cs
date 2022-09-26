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
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            richTextBox1.Text += label1.Text + " =" + textBox1.Text + "\n" + label2.Text + " = " + textBox2.Text + "\n" + label3.Text + " = " + textBox3.Text + "\n" + label4.Text + " = " + textBox4.Text + "\n";
            double w = 0;
            double c = 0;
            if (x * y > 0)
                c = Math.Pow((w + y), 2) - Math.Pow((w * y), 1 / 2);
            else
                if (x * y < 0)
                c = Math.Pow((w + y), 2) - Math.Pow(Math.Abs(w * y), 1 / 2);
            else
                if (x * y == 0)
                c = Math.Pow((w + y), 2) + 1;
            richTextBox1.Text += "Max = " + Convert.ToString(c) + "\n";
        }
    }
}
