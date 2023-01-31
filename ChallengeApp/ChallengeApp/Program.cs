using ChallengeApp;

Employee employee0 = new Employee("Adam", "Kowalski", "30");
Employee employee1 = new Employee("Mariusz", "Szewczyk", "25");
Employee employee2 = new Employee("Damian", "Krawczyk", "27");


employee0.AddPoints(4);
employee0.AddPoints(1);
employee0.AddPoints(3);
employee0.AddPoints(8);
employee0.AddPoints(3);

employee1.AddPoints(1);
employee1.AddPoints(8);
employee1.AddPoints(6);
employee1.AddPoints(4);
employee1.AddPoints(2);

employee2.AddPoints(9);
employee2.AddPoints(1);
employee2.AddPoints(4);
employee2.AddPoints(7);
employee2.AddPoints(1);

int maxPoints = -1;
Employee employeeWithMaxResult = null;

List<Employee> employees = new List<Employee>()
{
    employee0, employee1, employee2
};

foreach (var employee in employees)
{
    if (employee.Points > maxPoints)
    {
        maxPoints = employee.Points;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine($" Najlepszy pracownik jest: {employeeWithMaxResult.name} {employeeWithMaxResult.surname}" + $" ma {employeeWithMaxResult.Points} punkty");
