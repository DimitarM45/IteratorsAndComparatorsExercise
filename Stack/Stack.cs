using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> items;

        public Stack()
        {
            this.items = new List<T>();
        }

        public void Push(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
                items.Insert(0, elements[i]);
        }

        public void Pop()
        {
            if (items.Count == 0)
                Console.WriteLine("No elements");

            else
                items.RemoveAt(0);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
                yield return items[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
