using System;

namespace exOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Debil", Person.Gender.Male);
            Console.WriteLine(person1);
        }
    }
}