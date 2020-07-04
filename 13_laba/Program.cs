using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13_laba
{
    class Program
    {



        struct Train : IComparable
        {
            public string Punkt;
            public int Nomer;
            string DataTime;
            public string Time;
            public int Platforma;


            public Train(string Punkt, int Nomer, string DataTime, string Time, int Platforma)
            {
                this.Punkt = Punkt;
                this.Nomer = Nomer;
                this.DataTime = DataTime;
                this.Time = Time;
                this.Platforma = Platforma;
            }

            public int CompareTo(object obj) //компаратор, чтобы можно было юзать Sort()
            {
                Train a = (Train)obj;

                if (this.Punkt.CompareTo(a.Punkt) == -1) return -1;
                if (this.Punkt.CompareTo(a.Punkt) == 0) return 0;
                else return 1;
            }
            public override string ToString()
            {
                return string.Format("Поезд №{0} отправляется в {1} с платформы {2} в {3}.", Nomer, Punkt, Platforma, DataTime);
            }
        }

            static void Main(string[] args)
            {
                Console.WriteLine("Добро пожаловать! Введите данные для поездов");
                Random r = new Random();
                Train[] train = new Train[8];
                for (int i = 0; i < 8; i++)
                {   
                    int Nomer = r.Next(100);
                    try
                    {
                        Console.Write("Номер поезда: ");
                        Nomer = int.Parse(Console.ReadLine());
                    }
                    catch (Exception exc) { Console.WriteLine(exc.Message + " Номер по умолчанию - рандомный элемент"); }

                    
                   Console.Write("Пункт назначения поезда: ");
                   string Punkt = Console.ReadLine();
                    int Platforma = r.Next(10);

                    DateTime Data = DateTime.Now;
                    try
                    {
                        Console.Write("Время и дата отправления (дату по желанию; формат ввода - чч:мм/чч:мм дд:мм:гг): ");
                        Data = DateTime.Parse(Console.ReadLine());
                    }
                    catch (Exception exc) { Console.WriteLine(exc.Message + " Время и дата по умолчанию - сейчас"); }
                    string DataTime = Data.ToString("HH:mm d MMMM yyyy (dddd)");
                    string Time = Data.ToString("HH:mm");
                    train[i] = new Train(Punkt, Nomer, DataTime, Time, Platforma); // создал новый поезд

                }
                
                Array.Sort(train); 
                foreach (Train t in train)
                {
                    Console.WriteLine(t.ToString());
                }

                // поиск поезда
                Console.WriteLine("Введите время отправления для поиска или end для выхода");
                string input;
                while ((input = Console.ReadLine()) != "end") 
                {
                    bool trainFound = false;
                    for (int i = 0; i < 8; i++) 
                    {
                        if (train[i].Time == input) //сравнивает строки, если одинаковые - выводит поезд
                        {
                            Console.WriteLine(train[i]);
                            trainFound = true;
                        }
                    }
                    if (!trainFound) 
                    {
                        Console.WriteLine("Ничего не найдено. Повторите попытку"); 
                    }
                    Console.WriteLine("Введите время отправления для поиска или end для выхода");

                }

            }
        
    }
}
            