using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public void AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                this.Push(item);
            }
        }

        public bool IsEmpty()
        {
            return this.Count == 0;
        }
    }
}
