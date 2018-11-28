using System;
using System.Data;

namespace exOne
{
    public class Person
    {
        private string Name;
        private DateTime BirthDate;

        public enum Gender
        {
            Male,
            Female
        }

        public Person(string name, DateTime date)
        {
            this.Name = name;
            this.BirthDate = date;
        }

        public override string ToString()
        {
            return $"My name is: {this.Name}, I was born in {this.BirthDate:d}.";
        }
    }
}