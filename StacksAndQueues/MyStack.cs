using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StacksAndQueues
{
    public class MyStack<T>
    {
        protected class StackNode
        {
            public T data;
            public StackNode next;

            public StackNode(T data)
            {
                this.data = data;
            }

        }

        protected StackNode top;

        public T Pop()
        {
            if (top == null)
                throw new Exception();

            T item = top.data;
            top = top.next;
            return item;
        }

        public void Push(T item)
        {
            StackNode t = new StackNode(item);
            t.next = top;
            top = t;
        }

        public T Peek()
        {
            if (top == null)
                throw new Exception("Stack is empty.");

            return top.data;

        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public T Min()
        {
            // define a minimum
            T min = default;

            // if top is null, stack is empty, nothing to do here
            if (top == null)
                throw new Exception("Stack is empty.");
            // peek the value and set it to be the first min
            min = Peek();

            // iterate over the stack while it's not empty ,that is - while top is not null
            while (!IsEmpty())
            {
                // pop the value
                Pop();
                // if the stack is empty return Min immediately (only one element left)
                if (top == null)
                {
                    return min;
                }
                // otherwise compare next value to Min, and if it is less than min, set Min to be it
                if (Convert.ToInt32(Peek()) < Convert.ToInt32(min))
                {
                    min = Peek();
                }
            }

            return min;
        }


    }


}
