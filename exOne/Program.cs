using System;

namespace exOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Employee("Debil", Person.Gender.Male, 30000, "Bootstrapon developer");
            
            Console.WriteLine(person1);
        }
    }
}