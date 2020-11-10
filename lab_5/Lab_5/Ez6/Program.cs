using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ez6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
        }
    }

    class Stack<T> 
    {
        private List<T> data;

        public Stack() {
            List<T> lists = new List<T>();
            data = lists;
        }
        public void AddItem(T item)
        {
            data.Add(item);
        }

        public T RemoveItem()
        {
            T ret = data[0];
            data.RemoveAt(0);
            return ret;
        }
         
        public int ShowTheNumberOfItems()
        {
            return data.Count;
        }

        public T ShowMinItem()
        {
            return data.Min();
        }
        public T ShowMaxItem()
        {
            return data.Max();
        }
        public int FindAnItem(T item)
        {
            // return 0;
            return data.FindIndex(i => i.Equals(item));
        }
        public void PrintAllItems()
        {
            for(int i=0; i<data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        public void ClearAll()
        {
            data.Clear();
        }
    }
}
