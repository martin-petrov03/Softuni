using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class Collection<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public Collection(List<T> items)
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var currentItem in this.items)
            {
                yield return currentItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}