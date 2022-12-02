using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_2_4_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; ++i)
            {
                textBox1.Text += "" + Environment.NewLine;
                for (int j = 1; j <= i; ++j)
                {
                    textBox1.Text += " 2";
                }
                textBox1.Text += " 3" + Environment.NewLine;
                for (int j = 10 - i; j <= 10; ++j)
                    textBox1.Text += " " + (j % 10);
            }
        }
    }
}
