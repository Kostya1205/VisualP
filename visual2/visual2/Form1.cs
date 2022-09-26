using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual2
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
            richTextBox1.Text += "x =" + textBox1.Text + "\ny = " + textBox2.Text + "\nz = " + textBox3.Text+"\n";
            double w = 0;
            double c = 0;
            if (radioButton3.Checked == true) {
                richTextBox1.Text += radioButton3.Text + "\n";
                w = Math.Exp(x);
            }
            else
            if (radioButton2.Checked == true)
            {
                richTextBox1.Text += radioButton2.Text+"\n";
                w = Math.Pow(x, 2);
            }
            else
            {
                richTextBox1.Text += radioButton1.Text + "\n";
                w = Math.Sinh(x);
            }

            if (x * y > 0)
                c= Math.Pow((w + y), 2) - Math.Pow((w * y), 1 / 2);
            else
                if (x * y < 0)
                    c = Math.Pow((w + y), 2) - Math.Pow(Math.Abs(w * y), 1 / 2);
            else
                if(x*y==0)
                    c = Math.Pow((w + y), 2) + 1;

            if(checkBox4.Checked == true)
                c = Math.Abs(c);
            richTextBox1.Text += "Max = " + Convert.ToString(c) + "\n";
        }
    }
}