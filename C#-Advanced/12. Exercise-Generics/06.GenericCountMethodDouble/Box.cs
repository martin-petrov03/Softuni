using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable<T>
    {
        public List<T> box;

        public int CountGreater { get; private set; }

        public Box()
        {
            this.box = new List<T>();
        }

        public void Add(T item)
        {
            this.box.Add(item);
        }

        public void Compare(T item)
        {
            foreach (var currentItem in this.box)
            {
                if (currentItem.CompareTo(item) > 0)
                {
                    this.CountGreater++;
                }
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {            
            T tempItem = box[firstIndex];            

            box[firstIndex] = box[secondIndex];
            box[secondIndex] = tempItem;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (T item in this.box)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString();
        }
    }
}