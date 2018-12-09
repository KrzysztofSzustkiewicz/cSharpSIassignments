using System;
using System.Collections.Specialized;

namespace LookupCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var listDictionary = new ListDictionary(StringComparer.InvariantCultureIgnoreCase)
            {
                {"United States", "Estados Unidos"},
                {"Canada", "Canadá"},
                {"Spain", "España"}
            };

            Console.WriteLine(listDictionary["Canada"]);
            Console.WriteLine(listDictionary["Spain"]);
        }
    }
}