using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMP3
{
    class Class1
    {
        
        public static void sortvstavkami(int[] mas) //вставками
        {

            Console.WriteLine("Сортировка вставками");
            int[] result = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > mas[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = mas[i];
            }

            Console.WriteLine("Сортированный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
        public static void sortviborom(int[] mas) //Выбором
        {
            Console.WriteLine("Сортировка выбором");
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min_i = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min_i])
                    {
                        min_i = j;
                    }
                }
                int temp = mas[i];
                mas[i] = mas[min_i];
                mas[min_i] = temp;
            }
            Console.WriteLine("Сортированный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public static void sortshella(int[] vector) //Шелл
        {

            Console.WriteLine("Сортировка Шелла");
            int step = vector.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < vector.Length; i++)
                {
                    int value = vector[i];
                    for (j = i - step; (j >= 0) && (vector[j] > value); j -= step)
                    {
                        vector[j + step] = vector[j];

                    }
                    vector[j + step] = value;
                }
                step /= 2;

            }
            Console.WriteLine("Сортированный массив");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
    

