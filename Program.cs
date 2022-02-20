using System;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(50);
            queue.Enqueue(100);
            queue.Enqueue(150);
            queue.ShowQueue();
            Console.WriteLine(queue.Capacity());
            queue.Dequeue();
            queue.ShowQueue();
            Console.WriteLine(queue.Capacity());

            Console.ReadLine();
        }
    }
}