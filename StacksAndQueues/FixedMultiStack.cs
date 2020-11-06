using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class FixedMultiStack
    {
        private int numberOfStacks = 3;
        private int stackCapacity;
        private int[] values;
        private int[] sizes;

        public FixedMultiStack(int stackSize)
        {
            stackCapacity = stackSize;
            values = new int[stackSize * numberOfStacks];
            sizes = new int[numberOfStacks];
        }

        // Push value onto a stack
        public void Push(int stackNum, int value)
        {
            if (IsFull(stackNum))
            {
                throw new Exception("Stack is full.");
            }

            /* Increment the stack pointer and then update top value. */
            sizes[stackNum]++;
            values[IndexOfTop(stackNum)] = value;
        }

        // Pop item from top stack
        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                throw new Exception("Stack is empty.");
            }

            int topIndex = IndexOfTop(stackNum);
            int value = values[topIndex]; // Get top
            values[topIndex] = 0; // Clear
            sizes[stackNum]--;
            return value;
        }

        // return top element
        public int Peek(int stackNum)
        {
            if (IsEmpty(stackNum))
            {
                throw new Exception("Stack is empty.");
            }
            return values[IndexOfTop(stackNum)];
        }

        // return if stack is empty
        public bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        // return if stack is full
        public bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        // returns index of the top of the stack
        private int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }

    }
}
