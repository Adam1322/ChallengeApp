namespace ChallengeApp
{
    internal class Employee
    {
        private List<int> points = new List<int>();

        public string name { get; private set; }
        public string surname { get; private set; }
        public string age { get; private set; }
        public int Points
        {
            get
            {
                return this.points.Sum();
            }
        }

        public Employee(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void AddPoints(int point)
        {
            points.Add(point);
        }

    }
}