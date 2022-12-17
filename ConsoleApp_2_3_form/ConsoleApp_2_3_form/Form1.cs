using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            int q;
            if (int.TryParse(textBox2.Text, out q) && q >= 1 && q <= 100)
            {
            }
            else
            {
                textBox1.Text += "Число введено не корректно";
                return;
            }

            int count = 0;
            if (radioButton1.Checked)
            {
                for (int n = 101; n <= 999; n++)
                {
                    if (n % 10 == n / 100)
                    {
                        textBox1.Text += n + Environment.NewLine;
                        count++;
                    }
                    if (count == q)
                    {
                        break;
                    }
                }
            }

            if (radioButton2.Checked)
            {
                int i = 101;
                while (i <= 999)
                {
                    if (i % 10 == i / 100)
                    {
                        textBox1.Text += i + Environment.NewLine;
                        count++;
                    }
                    i++;
                    if (count == q)
                    {
                        break;
                    }
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
                        count++;
                    }
                    i++;
                    if (count == q)
                    {
                        break;
                    }
                }
                while (i <= 999);
            }
        }
    }
}