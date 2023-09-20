namespace Employee
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return score.sum();
            }
        }
        List<int> score = new List<int>();
        public Employee(string name, string surname, int age);
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }
        public void AddScore(int points)
        {
            this.score.Add(points);
        }
    }
}
