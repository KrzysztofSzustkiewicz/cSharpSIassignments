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
            return string.Format("My name is: {0}, I was born in {1:d}.", this.Name, this.BirthDate);
        }
    }
}
