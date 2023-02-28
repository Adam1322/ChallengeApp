namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        private List<float> grades = new List<float>();

        public EmployeeInFile(string name, string surname, string age)
            : base(name, surname, age)
        {
            using (FileStream fs = File.Create(fileName)) ;
        }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
                throw new Exception("Invalid grade value");
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            using (var reader = File.AppendText(fileName))
                switch (grade)
                {
                    case 'A':
                        this.AddGrade(100);
                        break;
                    case 'B':
                        this.AddGrade(80);
                        break;
                    case 'C':
                        this.AddGrade(60);
                        break;
                    case 'D':
                        this.AddGrade(40);
                        break;
                    case 'E':
                        this.AddGrade(20);
                        break;
                    case 'F':
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong latter");
                }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char character))
            {
                this.AddGrade(character);
            }
            else
            {
                throw new Exception("String is not a float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
