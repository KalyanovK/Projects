using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMP3_2_Часть
{
    class Program
    {
        static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            { return array; }
            int mid = array.Length / 2;
            return Merge(MergeSort(array.Take(mid).ToArray()), MergeSort(array.Skip(mid).ToArray()));
        }
        static int[] Merge(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < result.Length; ++i)
            {
                if (a < arr1.Length && b < arr2.Length)
                { result[i] = arr1[a] > arr2[b] ? arr2[b++] : arr1[a++]; }
                else
                { result[i] = b < arr2.Length ? arr2[b++] : arr1[a++]; }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Какой метод сортировки использовать?");
            Console.WriteLine("1 - сортировка слиянием");
            Console.WriteLine("2 - сортировка подсчётом (устойчивый алгоритм)");
            int vibor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов:");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 1; // регулировка колва массивов
            switch (vibor)
            {
                case 1:
                    {
                        for (int d = 0; d < k; d++)
                        {
                            Stopwatch watch2 = new Stopwatch();
                            watch2.Start();
                            int[] arr = new int[c];
                            Random r = new Random();
                            for (int i = 0; i < arr.Length; ++i)
                            {
                                arr[i] = r.Next(-100, 100);
                            }
                            Console.WriteLine("Массив до сортировки");
                            foreach (Int32 x in arr)
                                Console.Write(x + " ");
                            arr = MergeSort(arr);
                            Console.WriteLine("\nМассив после сортировки:");
                            foreach (int x in arr)
                                Console.Write(x + " ");
                            watch2.Stop();
                            long time2 = watch2.ElapsedMilliseconds;
                            Console.WriteLine("\nВремя выполнения программы в милисекундах: " + time2);
                        }
                        Console.ReadKey();
                        return;
                    }
                case 2:
                    {
                        for (int d = 0; d < k; d++)
                        {
                            Stopwatch watch2 = new Stopwatch();
                            watch2.Start();
                            int max = 100;
                            int min = -100;
                            int[] osnarr = new int[c];
                            int[] doparr = new int[max - min + 1];
                            int z = 0;
                            Random r = new Random();
                            for (int i = 0; i < c; ++i)
                            {
                                osnarr[i] = r.Next(-100, 100);
                            }
                            Console.WriteLine("Массив до сортировки\n");
                            foreach (Int32 x in osnarr)
                                Console.Write(x + " ");
                            for (int i = 0; i < max; i++)
                            {
                                doparr[i] = 0;
                            }
                            for (int i = 0; i < c; i++)
                            {
                                doparr[osnarr[i] - min]++;
                            }
                            for (int i = min; i <= max; i++)
                            {
                                while (doparr[i - min]-- > 0)
                                {
                                    osnarr[z] = i;
                                    z++;
                                }
                            }
                            Console.WriteLine("\nМассив после сортировки:\n");
                            foreach (int x in osnarr)
                                Console.Write(x + " ");
                            watch2.Stop();
                            long time2 = watch2.ElapsedMilliseconds;
                            Console.WriteLine("\nВремя выполнения программы в милисекундах: " + time2);
                        }
                        Console.ReadKey();
                        return;
                    }
            }
        }
    }
}



