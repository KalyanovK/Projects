using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14_laba
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = @"C:\Users\Костя\Desktop\f.txt";
            Random r = new Random();
            int R = 100; // регулировка значений массива
            int k = 10; // регулировка размера массивва

            Console.WriteLine("Enter количество компонент");
            try { k = int.Parse(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine(e.Message + "Значение по умолчанию - 10"); }

            //проверка
            if (!File.Exists(f))
                File.Create(f);

            using (var sw = new StreamWriter(f, true))
            {
                Console.WriteLine("Ваш массив: ");
                int[] mas = new int[k];
                    for (int i = 0; i < k; i++)
                    {
                        mas[i] = r.Next(-R, R);
                        sw.Write(mas[i] + ", ");
                    }
                int max = mas[0];
                for (int i = 0; i < k; ++i)
                {
                    if (mas[i] > max)
                        max = mas[i];
                }
                    sw.WriteLine("где MAX = " + max);
                
                long pr=1;
                for(int i=0; i<k; i++)
                {
                    pr *= mas[i];
                }
                sw.Write("Произведение компонент= " + pr);

                sw.WriteLine("");
            }


            using (var sr = new StreamReader(f))
            {
                var text = sr.ReadToEnd();
                Console.Write(text);
            }
            Console.WriteLine("Удалить файл? (Y/N)");
            string str = Console.ReadLine();
            if (str != "N")
            {
                File.Delete(f);
                Console.WriteLine("Файл удален.");
            }
            else
                Console.WriteLine("Ну ладно, нe буду ^_^");
            Console.ReadKey();
        }
    }
}