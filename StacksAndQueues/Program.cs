using System;
using System.Security.Cryptography.X509Certificates;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            TetaQueue<int> maliQ = new TetaQueue<int>();
            maliQ.Add(3);
            maliQ.Add(1);
            maliQ.Add(0);
            maliQ.Add(9);
            maliQ.Add(2);
            maliQ.Remove();
            Console.WriteLine(maliQ.Peek());




            /*MyQueue<string> maliQueue = new MyQueue<string>();
            maliQueue.Add("matej");
            Console.WriteLine(maliQueue.IsEmpty());
            Console.WriteLine(maliQueue.Peek());
            Console.WriteLine("Hello World!");*/
            Console.ReadLine();
        }
    }
}
