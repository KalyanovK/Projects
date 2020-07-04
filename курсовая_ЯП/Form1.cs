using System;
using System.Windows.Forms;
using System.IO;

namespace курсовая_ЯП
{
        public partial class Form1 : Form
    {
        public static void FindNums()
                {
                    string f = "задание1.txt"; // переменная с именем файла
                    if (!File.Exists(f)) // проверка на существование файла
                        File.Create(f); // если нет, то создать этот файл

                    using (var sw = new StreamWriter(f)) // открыт поток для записи
                    {
                        for (int i = 1000; i < 10000; i++) 
                        {
                            int a1 = i / 1000; // получение первой цифры
                            int a2 = (i % 1000) / 100; // получение второй цифры
                            int a3 = (i % 100) / 10; // получение третьей цифры
                            int a4 = i % 10; // получение последней цифры
                            if ( // сравниваем все цифры, если все разные - переход к следующей части
                                a1 != a2 &&
                                a1 != a3 &&
                                a1 != a4 &&
                                a2 != a3 &&
                                a2 != a4 &&
                                a3 != a4
                                )
                            {
                                sw.Write(i.ToString() + " "); // записать число i в файл в строковом формате
                            } 
                        }
                    }
                }
            public Form1()
        {
            InitializeComponent();
        }
        private void ПостановкаЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Получить все четырехзначные натуральные числа, в записи которых нет двух одинаковых цифр.");
        }
        // 1 задание
        private void Button1_Click(object sender, EventArgs e)
        {
            FindNums();
            richTextBox1.Text = File.ReadAllText("задание1.txt");   // чтение данных из файла и их вывод на экран 
        }
        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
