using System;
using System.Collections.Generic;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> mq = new MyQueue<int>(5);
            LinkedQueue<string> lq = new LinkedQueue<string>();
            mq.Enqueue(1);
            mq.Enqueue(2);
            mq.Enqueue(3);
            mq.Enqueue(4);
            lq.Enqueue("a");
            lq.Enqueue("b");
            lq.Enqueue("c");
            lq.Enqueue("d");
            bool b = lq.Contains("d");
            Console.WriteLine(b);
            lq.Enqueue(lq.Dequeue());
            lq.Clear();
            Console.WriteLine();
            string[] lqa = lq.ToArray();
            Console.WriteLine(string.Join(String.Empty, lqa));
            int[] array = mq.ToArray();
            
        }
    }
}
