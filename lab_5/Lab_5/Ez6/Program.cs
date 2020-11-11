using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack0 = new Stack<int>();
            Stack<int> stack1= new Stack<int>();

            Random r = new Random();

            for(int i = 0; i < 100; i++)
            {
                stack0.AddItem(r.Next(0, 200));
                stack1.AddItem(r.Next(0, 200));
            }

            Stack<int> stack2 = new Stack<int>();

            while (stack0.ShowTheNumberOfItems() != 0)
            {
                int a = stack0.RemoveItem();
                if(stack2.FindAnItem(a) != 1)
                {
                    stack2.AddItem(a);
                }
            }
            while (stack1.ShowTheNumberOfItems() != 0)
            {
                int a = stack1.RemoveItem();
                if(stack2.FindAnItem(a) != 1)
                {
                    stack2.AddItem(a);
                }
            }
            stack2.PrintAllItems();
            Console.ReadLine();
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
