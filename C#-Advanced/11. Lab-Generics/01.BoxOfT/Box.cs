using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxItems;

        public int Count { get { return this.boxItems.Count; } }

        public Box()
        {
            this.boxItems = new List<T>();
        }

        public void Add(T element)
        {
            this.boxItems.Add(element);
        }

        public T Remove()
        {            
            T lastElement = boxItems.Last();
            this.boxItems.RemoveAt(boxItems.Count - 1);
            return lastElement;
        }
    }
}