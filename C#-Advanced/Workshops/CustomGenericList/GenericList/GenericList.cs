using System;

namespace GenericList
{
    public class GenericList<T>
    {
        private const int defaultSize = 2;
        private T[] innerArr;

        public int Count { get; private set; } = 0;
        

        public GenericList()
        {
            innerArr = new T[defaultSize];
        }

        public GenericList(int initialSize)
        {
            innerArr = new T[initialSize];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return innerArr[index];
            }
        }

        public void Add(T value)
        {
            if (innerArr.Length == Count)
            {
                Grow();
            }

            innerArr[Count] = value;
            Count++;
        }

        public void AddRange(T[] list)
        {
            if (list.Length + Count >= innerArr.Length)
            {
                if (list.Length + Count > innerArr.Length * 2)
                {
                    Grow(list.Length + Count);
                }
                else
                {
                    Grow();
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                innerArr[Count] = list[i];
                Count++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            ShiftLeft(index);
            Count--;
            Shrink();
        }

        public bool Contains(T element)
        {
            bool result = false;
            for (int i = 0; i < Count; i++)
            {
                if (innerArr[i].Equals(element))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            ShiftRight(index);
            innerArr[index] = element;
            Count++;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (secondIndex < 0 || secondIndex > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            T tempElement = innerArr[firstIndex];
            innerArr[firstIndex] = innerArr[secondIndex];
            innerArr[secondIndex] = tempElement;
        }

        public void Shrink()
        {
            if (innerArr.Length / 4 > Count)
            {
                T[] tempArr = new T[innerArr.Length / 2];
                for (int i = 0; i < Count; i++)
                {
                    tempArr[i] = innerArr[i];
                }
                innerArr = tempArr;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(innerArr[i]);
            }
        }

        private void Grow()
        {
            Grow(innerArr.Length * 2);
        }

        private void Grow(int newSize)
        {
            T[] tempArr = new T[newSize];
            innerArr.CopyTo(tempArr, 0);
            innerArr = tempArr;
        }

        private void ShiftLeft(int position)
        {
            if (position < Count - 1)
            {
                for (int i = position; i < Count - 1; i++)
                {
                    innerArr[i] = innerArr[position + 1];
                }
                innerArr[Count - 1] = default;
            }
            else if (position == Count - 1)
            {
                innerArr[position] = default;
            }
        }

        private void ShiftRight(int position)
        {
            if (innerArr.Length == Count)
            {
                Grow();
            }
            for (int i = position; i < Count; i++)
            {
                innerArr[i + 1] = innerArr[i];
            }
            innerArr[position] = default;
        }
    }
}