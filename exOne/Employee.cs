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
            return string.Format("{0} I'm working as {1} and earning {2}$ i jest kurła {3} pomieszczeń",
                base.ToString(), this.proffession, this.salary, this.Room.Number);
        }
        
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}