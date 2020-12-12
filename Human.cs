namespace Homework.ITAcademy3
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; private set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
            FullName = $"{surname} {name}";
        }

        public override string ToString()
        {
            return $"{Name}, {Surname}";
        }
    }
}
