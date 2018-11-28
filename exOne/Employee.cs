namespace exOne
{
    public class Employee : Person
    {
        private int salary;
        private string proffession;
        private int classRooms;
        
        public Employee(string name, Gender gender, int salary, string proffession) : base(name, gender)
        {
            this.salary = salary;
            this.proffession = proffession;
            this.classRooms = new Room().Count;
        }

        public override string ToString()
        {
            return $"{base.ToString()}. I'm working as {this.proffession} and earning {this.salary}$ i jest kurła {this.classRooms} pomieszczeń";
        }
    }
}