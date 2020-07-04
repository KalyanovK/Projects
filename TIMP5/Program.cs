using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP5
{
    class Program
    {
        public static List<int>[] mas = new List<int>[1024];
        static void AddNumber(int Number)
        {
            int Index = HashFunс(Number);
            mas[Index].Add(Number);
        }
        
       
        static bool FindN(int Number)
        {
            bool fl = false;
            int Index = HashFunс(Number);

            if (mas[Index].Count != 0)
            {
                foreach (int N in mas[Index])
                {
                    if (N == Number)
                    {
                        fl = true;
                    }
                }
            }
            if (fl)
            {
                return true;
            }
            else return false;
        }
        static int HashFunс(int key)
        {
            var K = key * 6;
            int S = 6;
            return key * K % S;
        }
        static void Main(string[] args)
        {
            for(int i=0; i<2; ++i)
            {
                mas[i] = new List<int>();
            }
            
            AddNumber(8);
            AddNumber(10);
            AddNumber(81);
            FindN(8);
            FindN(1);
            FindN(81);

        }
    }
}
