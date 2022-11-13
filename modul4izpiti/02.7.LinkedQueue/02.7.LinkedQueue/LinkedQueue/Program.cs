using System;

namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Enqueue(1); queue.Enqueue(2);
            queue.Enqueue(3); queue.Enqueue(4);
            while (queue.Count != 0)                            //унищожава опашката
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.WriteLine();

            queue.Enqueue(1); queue.Enqueue(2);
            Console.WriteLine(String.Join(" ", queue.ToArray())); //опашката не се изтрива
        }
    }
}
