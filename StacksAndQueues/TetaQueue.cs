using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    /* Implement a Queue using two stacks.*/
    class TetaQueue<T> : MyStack<T>
    {
        MyStack<T> backStack = new MyStack<T>();
        MyStack<T> frontStack = new MyStack<T>();
        T temp;

        public void Add(T item)
        {
            if (backStack.IsEmpty() && frontStack.IsEmpty())
                backStack.Push(item);
            else if (!backStack.IsEmpty() && !frontStack.IsEmpty())
            {
                temp = frontStack.Pop();
                frontStack.Push(backStack.Pop());
                frontStack.Push(temp);
                backStack.Push(item);
            }
            if (frontStack.IsEmpty())
            {
                frontStack.Push(backStack.Pop());
                backStack.Push(item);
            }

            //backStack.Push(item);
        }

        new public T Peek()
        {
            if (backStack.IsEmpty() && frontStack.IsEmpty())
                throw new Exception("Stack is empty.");

            if (frontStack.IsEmpty())
                return backStack.Peek();

            return frontStack.Peek();

        }

        public T Remove()
        {
            if (backStack.IsEmpty() && frontStack.IsEmpty())
                throw new Exception("Stack is empty. Nothing to remove.");

            if (frontStack.IsEmpty())
                return backStack.Pop();
            else
                return frontStack.Pop();


        }

    }
}
