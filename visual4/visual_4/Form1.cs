using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeSize(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        public void ChangeSize(int colum,int row)
        {
            try
            {
                textBox4.Clear();
                Table1.Rows.Clear();
                Table1.Columns.Clear();
                for (int i = 1; i <= colum; i++)
                {
                    DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
                    c.HeaderText = "i = " + i;
                    Table1.Columns.Add(c);

                }
                Random rnd = new Random();
                for (int i = 1; i <= row; i++)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    for (int j = 0; j < colum; j++)
                    {
                        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                        cell.Value = rnd.Next(-100,100);
                        r.Cells.Add(cell);
                    }
                    r.HeaderCell.Value= "i=" + i;
                    Table1.Rows.Add(r);
                }
            }
            catch
            {
                textBox4.Text = "Ошибка";
            }
        }

        private void calculection()
        {
            int k=0;
            int value;
            for (int col = 0; col < Table1.Columns.Count; col++)
                for(int rows = 0; rows < (Table1.Rows.Count-1); rows++)
                {
                    int sum = 0;
                    value = Convert.ToInt32(Table1.Rows[rows].Cells[col].Value.ToString());
                    for(int f=0;f< (Table1.Rows.Count-1); f++)
                    {
                        if (f != rows)
                        {
                            sum += Convert.ToInt32(Table1.Rows[f].Cells[col].Value.ToString());
                        }
                    }
                    if (value > sum)
                    {
                        k++;
                    }
                }
            textBox3.Text=Convert.ToString(k);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeSize(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculection();
        }
        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text=" N of Rows = "+Convert.ToString(e.RowIndex)+" N of Collum = " + Convert.ToString(e.ColumnIndex)+ " Value = " + Convert.ToString(Table1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //textBox5.Text=" N of Rows = "+Convert.ToString(Table1.CurrentCell.RowIndex+1)+" N of Collum = " + Convert.ToString(Table1.CurrentCell.ColumnIndex + 1)+ " Value = " + Convert.ToString(Table1.CurrentCell.Value);
        }
    }
}
