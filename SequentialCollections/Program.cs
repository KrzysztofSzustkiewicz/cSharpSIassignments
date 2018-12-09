using System;
using System.Collections;

namespace SequentialCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var queue = new Queue();
            
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            var queueLen = queue.Count;

            for (var i = 0; i < queueLen; i++)
            {
                queue.Dequeue();
            }
            
            Console.WriteLine(queue.Count);
        }
    }
}