using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _15_laba
{
    public partial class Лабораторная : Form
    {
        public WMPLib.WindowsMediaPlayer m = new WMPLib.WindowsMediaPlayer();


        public Лабораторная()
        {
            InitializeComponent();
            m.URL = ("theme.mp3");
            m.controls.play();
            trackBar1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            var b = Convert.ToDouble(a);
            var S_pov = b * b * 6;
            textBox3.Text = S_pov.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            var b = Convert.ToDouble(a);
            var S_grani = b * b;
            textBox3.Text = S_grani.ToString();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            var b = Convert.ToDouble(a);
            var V = b * b * b;
            textBox3.Text = V.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void ОписаниеЗаданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По нажатию кнопки реализовать вычисление значения арифметического выражения(выражений), которое было вами разработано в лабораторной работе № 2, вывести его в TextBox, использовать Lable с текстом этого выражения для пояснения. Задание из второй лабораторной работы: Найти площадь грани, площадь поверхности и объем куба, длина ребра которого вводится с клавиатуры.");
        }

        private void ОписаниеЗаданияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В RadioButton вывести: каким методом решалось уравнение из лабораторной работы №3, после нажатия кнопки и ввода координаты х. Задание из третьей лабораторной работы: Даны цифры a, b, c, d, составляющие четырехзначное число. Определить, все ли четыре цифры различны.");
        }

        private void ОписаниеЗаданияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBox задействовать для выбора метода решения циклической задачи из лабораторной работы № 4, после выбора метода сразу вывести результат. Задание из четвертой лабораторной работы: Дано целое K. Сколько цифр в числе 5*К?");
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string k = textBox4.Text;
            int K = Convert.ToInt32(k);
            K *= 5;
            int cnt = 0;
            for(int n=K; n>0; cnt++)
            {
                n /= 10;
                
            }
            textBox5.Text = cnt.ToString();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            string k = textBox4.Text;
            int K = Convert.ToInt32(k);
            K *= 5;
            int Cnt = 0;
            while (K > 0)
            {
                K /= 10;
                ++Cnt;
            }
            textBox5.Text = Cnt.ToString();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string k = textBox4.Text;
            var K = Convert.ToInt32(k);
            K *= 5;
            int count = 0;
            do
            {
                K /= 10;
                ++count;
            }
            while (K > 0);
            textBox5.Text = count.ToString();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string answer;
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox9.Text);
            int c = Convert.ToInt32(textBox8.Text);
            int d = Convert.ToInt32(textBox7.Text);
            if (a == b || a == c || a == d || b == c || b == d || c == d)
            {
                answer = "Есть одинаковые цифри";
            }
            else
                answer = "Все цифри разные";

            if (radioButton1.Checked)
                MessageBox.Show(answer);
            if (radioButton2.Checked)
                textBox6.Text = answer;
            if (radioButton3.Checked)
                label2.Text = answer;
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        // подарил трекбару возможность регулировать громкость
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            m.settings.volume=trackBar1.Value;
            
        }

        // режим без звука
        private void Button5_Click(object sender, EventArgs e)
        {
            m.settings.volume = 0; 
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void TextBox9_Click(object sender, EventArgs e)
        {
            textBox9.SelectAll();
        }

        private void TextBox8_Click(object sender, EventArgs e)
        {
            textBox8.SelectAll();
        }

        private void TextBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectAll();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №15");
        }
    }
}
