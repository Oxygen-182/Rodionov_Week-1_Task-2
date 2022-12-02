using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_2_3_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (radioButton1.Checked)
            {
                for (int n = 101; n <= 999; n++)
                {
                    if (n % 10 == n / 100)
                    {
                        textBox1.Text += n + Environment.NewLine;
                    }
                }
            }

            if (radioButton2.Checked)
            {
                int i = 101;
                while (i < 1000)
                {
                    if (i % 10 == i / 100)
                    {
                        textBox1.Text += i + Environment.NewLine;
                    }
                    i++;
                }
            }

            if (radioButton3.Checked)
            {
                int i = 101;
                do
                {
                    if (i % 10 == i / 100)
                    {
                        textBox1.Text += i + Environment.NewLine;
                    }
                    i++;
                }
                while (i < 1000);
            }
        }
    }
}