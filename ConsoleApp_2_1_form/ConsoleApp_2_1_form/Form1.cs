using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_2_1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            if (x * x + y * y < 100 && y < Math.Abs(x))
                textBox3.Text += "Точка находится внутри окружности";
            else if (x * x + y * y > 100 || y > Math.Abs(x))
                textBox3.Text += "Точка находится вне окружности";
            else
                textBox3.Text += "Точка находится на границе окружности";
        }
    }
}
