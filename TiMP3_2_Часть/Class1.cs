using System;


namespace TiMP3_2_Часть
{
    public class Class1<T>
    {
        private T[] items;
        public Class1(int size)
        {
            items = new T[size];
        }
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key] = item;
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Equals(item);
        }
        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}
