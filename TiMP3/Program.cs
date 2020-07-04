using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TiMP3
{
    class Program
    {
            static void Main(string[] args)
            {
            int c = 1000;
            int[] mas = new int[c];
            Random r = new Random();
            for (int i = 0; i < c; i++)
            {
                mas[i] = r.Next();
            }
            Console.WriteLine("Несортированный массив");
            for (int i = 0; i < c; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch.Start();
            Class1.sortvstavkami(mas);
            Console.WriteLine();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            stopwatch1.Start();
            Class1.sortviborom(mas);
            Console.WriteLine();
            stopwatch1.Stop();
            TimeSpan ts1 = stopwatch1.Elapsed;

            stopwatch2.Start();
            Class1.sortshella(mas);
            Console.WriteLine();
            stopwatch2.Stop();
            TimeSpan ts2 = stopwatch2.Elapsed;


            Console.WriteLine("время работы сортировки вставками " + ts);
            Console.WriteLine("время работы сортировки выбора " + ts1);
            Console.WriteLine("время работы сортировки Шелла " + ts2);
            Console.ReadLine();
        }

    }
        
    
}

