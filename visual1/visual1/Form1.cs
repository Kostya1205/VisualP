using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Lab.rab.№1 St. gr. 10701121 Zhurovich K.S.\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double w = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z))); 
            richTextBox1.Text += "Calculation result = " + Convert.ToString(w)+"\n";
        }

    }
}
