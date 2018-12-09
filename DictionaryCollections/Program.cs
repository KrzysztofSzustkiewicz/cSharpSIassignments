using System;
using System.Collections;

namespace DictionaryCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hashtable = new Hashtable
            {
                {"0", "Zero"},
                {"1", "One"},
                {"2", "Two"},
                {"3", "Three"},
                {"4", "Four"},
                {"5", "Five"},
                {"6", "Six"},
                {"7", "Seven"},
                {"8", "Eight"},
                {"9", "Nine"}
            };


            var number = "122142320458306043580280324234";
            
            foreach (var num in number)
            {
                string numKey = num.ToString();
                if (hashtable.ContainsKey(numKey))
                {
                    Console.WriteLine(hashtable[numKey]);
                }
            }
        }
    }
}