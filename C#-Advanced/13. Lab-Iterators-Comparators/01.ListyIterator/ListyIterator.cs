using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
            }
            else {
                return false;
            }
            return true;
        }

        public bool HasNext()
        {
            if (this.index < this.items.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.items.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            Console.WriteLine(this.items[this.index]);
        }
    }
}