using System;
using System.Collections;

namespace SequentialCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region QueueCollection
            
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
            
            #endregion 
            
            #region StackCollection
            
            var stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            
            PrintStackValues();
            
            while (stack.Count != 0)
            {
                stack.Pop();
                PrintStackValues();
            }
            
            Console.WriteLine(stack.Count);

            void PrintStackValues()
            {
                foreach (var value in stack)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("\t");
            }

            #endregion
            
            

        }
    }
}