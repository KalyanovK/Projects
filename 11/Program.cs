using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static double H(double a, double b, double c)
        {
            return ((Math.Max(a, a + b) + Math.Max(a, b + c)) / (1 + Math.Max(a + b * c, 1.15)));
        }

        
        static void Main(string[] args)
        {
            double x = 0;
            try
            {
                Console.Write("x=");
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Неверный формат числа! Будет присвоено значение по умолчанию (0)");
            }
            Console.Write("y=");
            double y = 0;
            try { y = Convert.ToDouble(Console.ReadLine()); }
            catch { Console.WriteLine("Ошибка! Неверный формат числа! Будет присвоено значение по умолчанию (0"); }
            Console.Write("z=");
            double z = 0;
            try { z = Convert.ToDouble(Console.ReadLine()); }
            catch { Console.WriteLine("Ошибка! Неверный формат числа! Будет присвоено значение по умолчанию (0)"); }
            double res = H(1, 2, 3) + H(x, y, z);
            Console.WriteLine(res);
        }
    }
}