using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GenericCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>()
            {
                {93, "Afghanistan"},
                {355, "Albania"},
                {213, "Algeria"},
                {376, "Andorra"},
                //{"244", "Angola"},
                //{"672", "Antarctica"}
            };

            Console.WriteLine(dictionary[93]);

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.ToString());
            }
        }
    }
}