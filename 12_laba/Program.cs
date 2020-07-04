using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_laba
{
    class Prgnk
    {
        private int X1, Y1, X2, Y2, X3, Y3;
        public Prgnk(string a)
        {
            Console.WriteLine(a);
        }
        public Prgnk()
        {
            
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int S { get; set; }
        public int V { get; set; }
        public Prgnk(int x, int y, int s, int v)
        {
            X = x;
            Y = y;
            X1 = x;
            Y1= y + v;
            X2 = x + s;
            Y2 = y+v;
            X3 = x + s;
            Y3 = y;
            S = s;
            V = v;
        }
        public new string ToString()
        {
            return string.Format("A({0},{1}); B({2},{3}); C({4},{5}); D({6},{7}); высота:{8}; ширина:{9}", X, Y, X1, Y1, X2, Y2, X3, Y3, S, V);
        }
        public void Action(int x, int y)
        {
            Console.WriteLine("Перемещаю...");
            X += x;
            Y += y;
            X1 +=x;
            Y1 += y;
            X2 += x;
            Y2 += y;
            X3 += x;
            Y3 += y;
            Console.WriteLine("Готово! ");
        }
        // тут перегрузка оператора для создания большого пр-ка из двух заданных пр-гов
        public static Prgnk operator+ (Prgnk p1, Prgnk p2)
        {
            Console.WriteLine("Леплю большой прямоугольник из двух заданных...");
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;
            int s = p1.S + p2.S;
            int v = p1.V + p2.V;
            Prgnk res = new Prgnk (x,y,v,s);
            Console.WriteLine("Готово! " +  res);
            return null;

        }
        // объединение пр-ков
        public static void Action(Prgnk a, Prgnk b)
        {
            Console.WriteLine("Объединяю прямоугольники...");
            int Ax = Math.Min(a.X, b.X);
            int Ay = Math.Min(a.Y, b.Y);
            int Bx = Math.Min(a.X1, b.X1);
            int By = Math.Max(a.Y1, b.Y1);
            int Cx = Math.Max(a.X2, b.X2);
            int Cy = Math.Max(a.Y2, b.Y2);
            int Dx = Math.Max(a.X3, b.X3);
            int Dy = Math.Min(a.Y3, b.Y3);
            int Visota = By - Ay;
            int Shirina = Cx - Bx;
            Console.WriteLine("Минимальный прямоугольник, который содержит в себе два заданных пр-ника: A({0}, {1}), B({2}, {3}), C({4}, {5}), D({6}, {7}), Высота = {8}, Ширина = {9};", Ax,Ay,Bx,By,Cx,Cy,Dx,Dy,Visota,Shirina);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Prgnk start = new Prgnk("Hello Freundo.");

            // первый пр-ник
            Console.WriteLine("Введите точку А (это будет нижняя левая точка, все остальные точки строятся по часовой стрелке), а также высоту и ширину прямоугольника");
            Console.Write("x= ");
            int x1=0;
            try { x1 = Convert.ToInt32(Console.ReadLine());}       
            catch {Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0");}
            int y1 = 0;
            Console.Write("y= ");
            try { y1 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            int s1 = 0;
            Console.Write("ширина= ");
            try { s1 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("высота= ");
            int v1 = 0;
            try { v1 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Prgnk p1 = new Prgnk(x1, y1, s1, v1);      
            Console.WriteLine("Предварительный прямоугольник: " + p1);


            // здесь запрос и вызов метода на перемещение
            Console.WriteLine("Хотите задать перемещение? Если нет, просто введите нули");
            Console.Write("перемещение по оси Ox= ");
            int a = 0;
            try { a = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("перемещение по оси Oy= ");
            int b = 0;
            try { b = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            p1.Action(a, b);
            Console.WriteLine("Конечный прямоугольник: " + p1);
            Console.WriteLine();


            // создаю второй пр-ник
            Console.WriteLine("Строим второй прямоугольник...");
            Console.Write("x= ");
            int x2 = 0;
            try { x2 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("y= ");
            int y2 = 0;
            try { y2 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("ширина= ");
            int s2 = 0;
            try { s2 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("высота= ");
            int v2 = 0;
            try { v2 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Prgnk p2 = new Prgnk(x2, y2, s2, v2);
            Console.WriteLine("Предварительный прямоугольник #2: " + p2);


            // опять запрос на перемещение
            Console.WriteLine("Сместить прямоугольник? Если нет, введите нули");
            Console.Write("перемещение по оси Ox= ");
            int a1 = 0;
            try { a1 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            Console.Write("перемещение по оси Oy= ");
            int b1 = 0;
            try { b1 = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Внимание! Нужно вводить ЦЕЛЫЕ числа! Впредь будьте внимательнее. По умолчанию присвоено значение 0"); }
            p2.Action(a1, b1);
            Console.WriteLine("Конечный прямоугольник" + p2);
            Console.WriteLine();


            // вывод объединенного пр-ника
            Prgnk.Action(p1, p2);
            Console.WriteLine();


            Prgnk p3 = new Prgnk(); // mega пр-ник
            p3 = p1 + p2;
            Console.WriteLine(p3);
            Console.ReadKey();
        }
    }
}
