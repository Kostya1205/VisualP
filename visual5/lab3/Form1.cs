using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string Items = comboBox1.SelectedItem.ToString();
                int Number = 0, kol = 0;
                for (int i = 0; i < Items.Length; i++)
                {
                    Number = 0;
                    while (i < Items.Length && (Items[i] == '1' || Items[i] == '0'))
                    {
                        Number++;
                        i++;
                    }
                    if (Number == 5)
                    {
                        kol++;
                    }
                }
                label2.Text = Convert.ToString(kol);
        }

    }
}
