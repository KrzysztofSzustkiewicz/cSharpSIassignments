using System;

namespace exOne
{
    public class Employee : Person, ICloneable
    {
        private int salary;
        private string proffession;
        public Room Room { get; set; }
        
        public Employee(string name, DateTime date, int salary, string proffession) : base(name, date)
        {
            this.salary = salary;
            this.proffession = proffession;
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} I'm working as {this.proffession} and earning {this.salary}$" +
                   $" i jest kurła {this.Room.Number} pomieszczeń";
        }
        
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}