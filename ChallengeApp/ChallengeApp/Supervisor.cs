//namespace ChallengeApp
//{
//    public class Supervisor : IEmployee
//    {
//        public delegate void GradeAddedDelegate(object sender, EventArgs args);

//        public event GradeAddedDelegate GradeAdded;
//        private const string fileName = "gradesSupervisor.txt";

//        private List<float> grades = new List<float>();
//        public Supervisor(string name, string surname, string age)
//        {
//            this.Name = name;
//            this.Surname = surname;
//            this.Age = age;
//        }
//        public string Name { get; private set; }
//        public string Surname { get; private set; }
//        public string Age { get; private set; }

//        public void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            if (GradeAdded != null)
//            {
//                GradeAdded(this, new EventArgs());
//            }
//            else
//            {
//                throw new Exception("invalid grade value");
//            }
//        }

//        public void AddGrade(double grade)
//        {
//            float valueInFloat = (float)grade;
//            this.AddGrade(valueInFloat);
//        }

//        public void AddGrade(int grade)
//        {
//            float gradeAsFloat = (float)grade;
//            this.AddGrade(gradeAsFloat);
//        }
//        public void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A':
//                    this.grades.Add(100);
//                    break;
//                case 'B':
//                    this.grades.Add(80);
//                    break;
//                case 'C':
//                    this.grades.Add(60);
//                    break;
//                case 'D':
//                    this.grades.Add(40);
//                    break;
//                case 'E':
//                    this.grades.Add(20);
//                    break;
//                case 'F':
//                    this.grades.Add(0);
//                    break;
//                default:
//                    throw new Exception("Wrong latter");
//            }
//        }
//        public void AddGrade(string grade)
//        {

//            if (float.TryParse(grade, out float result))
//            {
//                this.AddGrade(result);
//            }
//            else
//            {
//                switch (grade)
//                {
//                    case "6":
//                        this.grades.Add(100);
//                        break;
//                    case "-6":
//                        this.grades.Add(95);
//                        break;
//                    case "+5":
//                        this.grades.Add(85);
//                        break;
//                    case "5":
//                        this.grades.Add(80);
//                        break;
//                    case "-5":
//                        this.grades.Add(75);
//                        break;
//                    case "+4":
//                        this.grades.Add(65);
//                        break;
//                    case "4":
//                        this.grades.Add(60);
//                        break;
//                    case "-4":
//                        this.grades.Add(55);
//                        break;
//                    case "+3":
//                        this.grades.Add(45);
//                        break;
//                    case "3":
//                        this.grades.Add(40);
//                        break;
//                    case "-3":
//                        this.grades.Add(35);
//                        break;
//                    case "+2":
//                        this.grades.Add(25);
//                        break;
//                    case "2":
//                        this.grades.Add(20);
//                        break;
//                    case "-2":
//                        this.grades.Add(15);
//                        break;
//                    case "1":
//                        this.grades.Add(0);
//                        break;
//                    default:
//                        throw new Exception("invalid grade value");
//                }
//            }
//        }
//        public override Statistics GetStatistics()
//        {
//            var gradesFromFile = this.ReadGradesFromFile();
//            var statistics = this.CountStatistics(gradesFromFile);
//            return statistics;
//        }
//        private List<float> ReadGradesFromFile()
//        {
//            var grades = new List<float>();
//            if (File.Exists(fileName))
//            {
//                using (var reader = File.OpenText(fileName))
//                {
//                    var line = reader.ReadLine();
//                    while (line != null)
//                    {
//                        var number = float.Parse(line);
//                        grades.Add(number);
//                        line = reader.ReadLine();
//                    }
//                }
//            }
//            return grades;
//        }
//        private Statistics CountStatistics(List<float> grades)
//        {
//            var statistics = new Statistics();
//            foreach (var grade in grades)
//            {
//                statistics.AddGrade(grade);
//            }
//            return statistics;
//        }
//    }
//}