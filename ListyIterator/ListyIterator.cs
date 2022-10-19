using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;

        private int index;

        public ListyIterator(List<T> elements)
        {
            index = 0;

            this.elements = elements;
        }

        public bool Move()
        {
            if (index < elements.Count - 1)
            {
                index++;

                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return index < elements.Count - 1; 
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(elements[index]);
        }
    }
}
