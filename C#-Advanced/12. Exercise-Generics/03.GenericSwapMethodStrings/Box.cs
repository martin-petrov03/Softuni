using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public List<T> box;
        public Box()
        {
            this.box = new List<T>();
        }

        public void Add(T item)
        {
            this.box.Add(item);
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