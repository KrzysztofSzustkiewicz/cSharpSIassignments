using System;
using System.Data;

namespace exOne
{
    public class Person
    {
        private readonly string Name;
        private readonly DateTime BirthDate;
        private readonly Gender gender;

        public enum Gender
        {
            Male,
            Female
        }

        public Person(string name, Gender gender)
        {
            this.Name = name;
            this.BirthDate = DateTime.Now;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"My name is: {this.Name}, I was born in {this.BirthDate:d} and I'm a {this.gender}";
        }
    }
}