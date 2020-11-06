using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class MyQueue<T>
    {
        private class QueueNode
        {
            internal T data;
            internal QueueNode next;

            public QueueNode(T data)
            {
                this.data = data;
            }
        }

        private QueueNode first;
        private QueueNode last;

        public void Add(T item)
        {
            QueueNode t = new QueueNode(item);

            if (last != null)
            {
                last.next = t;
            }

            last = t;

            if (first == null)
            {
                first = last;
            }

        }

        public T Remove()
        {
            if (first == null)
                throw new Exception("No such element.");
            T data = first.data;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            return data;
        }

        public T Peek()
        {
            if (first == null)
                throw new Exception("Queue is empty.");
            return first.data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
