using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StacksAndQueues
{
    class BasicStack<T>
    {
        private T[] arrayData;
        private const int defaultSize = 30;
        private int index;

        public BasicStack()
        {
            arrayData = new T[defaultSize];
            index = 0;
        }

        public T Peek()
        {
            if (index == 0)
                throw new InvalidOperationException("Empty stack");
            return arrayData[index - 1];
        }

        public T Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Empty stack");

            return arrayData[--index];
        }

        public T PopAt(int index)
        {
            return arrayData[index];
        }

        public void Push(T obj)
        {
            if (index == arrayData.Length)
            {
                T[] newArray = new T[2 * arrayData.Length];
                Array.Copy(arrayData, 0, newArray, 0, index);
                arrayData = newArray;
            }

            arrayData[index] = obj;
            index++;
        }


    }
}
