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

namespace ConsoleApp_2_2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int n = int.Parse(textBox1.Text);

            if (n % 1 == 0) { }
            else
            {
                textBox2.Text += "Номер телевизионного канала введено некорректно";
                return;
            }

            if (n < 0)
            {
                textBox2.Text += "Номер телевизионного канала не может быть отрицательным";
                return;
            }
            switch (n)
            {
                case 1:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Вести" + Environment.NewLine + "Что? Где? Когда?" + Environment.NewLine + "Время покажет"; break;
                case 2:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "60 минут" + Environment.NewLine + "Кто против?" + Environment.NewLine + "Вечер с Владимиром Соловьевым"; break;
                case 3:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Чрезвычайное происшествие" + Environment.NewLine + "Сегодня" + Environment.NewLine + "Место встречи"; break;
                case 4:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Новости культуры" + Environment.NewLine + "Искусственный отбор" + Environment.NewLine + "Забытое ремесло"; break;
                case 5:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Известия" + Environment.NewLine + "След" + Environment.NewLine + "Детективы"; break;
                case 6:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Спокойной ночи, малыши!" + Environment.NewLine + "Что в тарелке?" + Environment.NewLine + "Игра с умом"; break;
                case 7:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "За Дело!" + Environment.NewLine + "Календарь" + Environment.NewLine + "Новости"; break;
                case 8:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Территория заблуждений" + Environment.NewLine + "Засекреченные списки" + Environment.NewLine + "Тайны Чапман"; break;
                case 9:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Специальный репортаж" + Environment.NewLine + "Открытый эфир" + Environment.NewLine + "Между тем"; break;
                case 10:
                    textBox2.Text += "НАИБОЛЕЕ ПОПУЛЯРНЫЕ ПРОГРАММЫ:" + Environment.NewLine;
                    textBox2.Text += Environment.NewLine + "Вечер во Владимире" + Environment.NewLine + "Вечерний зефир" + Environment.NewLine + "Телефорум"; break;
                default: textBox2.Text += "ВЫ ОШИБЛИСЬ"; break;
            };
        }
    }
}
