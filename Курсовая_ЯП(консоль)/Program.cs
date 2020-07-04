using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовая_ЯП_консоль_
{
    class Program
    {
        public static Random r = new Random();
        public static void FillMatrix(int[,] arr, uint m, uint n) //данный метод заполняет матрицу значениями от 0 до reg-1 и выводит ее на экран
        {
            int reg = 10; // регулировка значений рандома

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(reg);   // заполняет эл-ми
                    Console.Write(arr[i, j] + " "); // выводит на экран
                }
                Console.WriteLine(); // пустая строка нужна, чтобы матрица была красивая
            }
        }


        static int Determinant(int[,] arr)
        {
            int result = 0;

            if (arr.Length == 1) //если состоит из одного элемента, вернуть этот элемент
            {
                return arr[0, 0];
            }

            if (arr.GetLength(0) == arr.GetLength(1)) // проверяем, квадратная ли матрица
            {
                for (int el = 0; el < arr.GetLength(1); el++) // идем по столбцам 
                {
                    int[,] temp = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1]; // массив под минор
                    for (int i = 0; i < temp.GetLength(0); i++)
                        for (int j = 0; j < temp.GetLength(1); j++)
                        {
                            temp[i, j] = (j < el) ? arr[i + 1, j] : arr[i + 1, j + 1]; // темп будет заполняться в зависимости от "зачеркнутой" строки и столбца
                        }

                    result += (arr[0, el] * Pow1(el) * Determinant(temp)); // формула для определителя(когда считаем через алгеб. дополнения)   
                }

                return result;
            }
            else return 0;  

        }
        static int Pow1(int input)  // метод, который определяет степень (-1) в формуле (-1)^(i+j)
        {
            if (input % 2 == 0) return 1;
            return -1;
        }


        struct Elem
        {
            public int IndexI { get; set; }
            public int IndexJ { get; set; }
            public int Element { get; set; }
        }

        static void Main(string[] args)
        {
            uint m = 3; // значения по умолчанию
            uint n = 3;
            // создали 4 матрицы
            int[,] A = new int[m, n];
            int[,] B = new int[m, n];
            int[,] C = new int[m, n];
            int[,] D = new int[m, n];
            int[,] E = new int[m, n]; // создали матрицу Е

            int menu = 0, prgm = 0; // переменные для двухуровнего меню
            do
            {
                Console.WriteLine("Нажмите 1, чтобы начать");
                Console.WriteLine("Нажмите 2, чтобы посмотреть задание");
                Console.WriteLine("Нажмите 3, чтобы выйти");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (menu)
                {
                    case (1):
                        {
                            do
                            {
                                Console.WriteLine("Нажмите 1, чтобы задать размер матриц (в случае отсуствия заданных значений, будет задана размерность по умолчанию - 3*3)");
                                Console.WriteLine("Нажмите 2 для просмотра матриц");
                                Console.WriteLine("Нажмите 3 для просмотра матрицы Е");
                                Console.WriteLine("Нажмите 4 для просмотра определителя матрицы Е");
                                Console.WriteLine("Нажмите 5 для выхода в главное меню");
                                prgm = Convert.ToInt32(Console.ReadLine());
                                switch (prgm)
                                {
                                    case (1):
                                        {
                                            // блоки try-catch на проверку вводимых символов
                                            Console.Write("Введите количество строк (целое положительное число):");
                                            try
                                            {
                                                m = Convert.ToUInt32(Console.ReadLine());
                                            }
                                            catch (Exception exc) { Console.WriteLine(exc.Message + " Будет присвоено значение по умолчанию: 3"); }
                                            Console.Write("Введите количество столбцов (целое положительное число):");
                                            try
                                            {
                                                n = Convert.ToUInt32(Console.ReadLine());
                                            }
                                            catch (Exception exc) { Console.WriteLine("Ошибка: " + exc.Message + " Будет присвоено значение по умолчанию: 3"); }
                                            break;
                                        }
                                    case (2):
                                        {
                                            // заполнили их и вывели на экран
                                            Console.WriteLine("A");
                                            FillMatrix(A, m, n);
                                            Console.WriteLine("B");
                                            FillMatrix(B, m, n);
                                            Console.WriteLine("C");
                                            FillMatrix(C, m, n);
                                            Console.WriteLine("D");
                                            FillMatrix(D, m, n);
                                            break;
                                        }
                                    case (3):
                                        {

                                            Elem[] elem = new Elem[m * n]; // создали структуру
                                            int k = 0; // счетчик (будет считать кол-во элементов в матрице, которые совпадут)
                                            for (int i = 0; i < m; i++)
                                            {
                                                for (int j = 0; j < n; j++)
                                                {
                                                    if (A[i, j] == B[i, j] && A[i, j] == C[i, j] && A[i, j] == D[i, j] && B[i, j] == C[i, j] && B[i, j] == D[i, j] && C[i, j] == D[i, j]) //сравниваем каждый элемент у 4-ех матриц
                                                    {
                                                        elem[k].IndexI = i; // передает координаты,
                                                        elem[k].IndexJ = j; // где нашлось совпадение
                                                        elem[k].Element = A[i, j]; // здесь элемент передаем по координатам индексов
                                                        k++;
                                                    }
                                                }
                                            }


                                            for (int i = 0; i < m; i++)
                                            {
                                                for (int j = 0; j < n; j++)
                                                {
                                                    E[i, j] = 0; // присваивает всем элементам матрицы Е нули
                                                }
                                            }

                                            for (int i = 0; i < k; i++)
                                            {
                                                E[elem[i].IndexI, elem[i].IndexJ] = elem[i].Element; // точечно присваивает ненулевой элемент, который совпал во всех матрицах, на то же место
                                            }                                                        // при этом нули остаются на своих местах                                     
                                            Console.WriteLine("E");
                                            for (int i = 0; i < m; i++) // вывод матрицы
                                            {
                                                for (int j = 0; j < n; j++)
                                                {
                                                    Console.Write(E[i, j] + " ");
                                                }
                                                Console.WriteLine();
                                            }
                                            break;
                                        }
                                    case (4):
                                        {
                                            Console.WriteLine("Определитель получившейся матрицы E равен " + Determinant(E));
                                            break;
                                        }
                                    case (5):
                                        {
                                            prgm =5;
                                            break;
                                        }
                                }
                            }
                            while (prgm < 5);
                            break;
                        }

                    case (2):
                        {
                            Console.WriteLine("Даны четыре матрицы размера m*n. Если элементы, стоящие на одинаковых позициях в этих матрицах, равны – поместить их в новую матрицу на соответствующие позиции. Остальные элементы новой матрицы приравнять к нулю. Найти определитель новой матрицы.");
                            break;
                        }
                    case (3): return;
                }
            } while (menu < 3);
        }
    }
}