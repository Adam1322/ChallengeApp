using ChallengeApp;


Console.WriteLine("Witamy w programie oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj imię");
string name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko");
string surname = Console.ReadLine();
Console.WriteLine("Podaj wiek");
string age = Console.ReadLine();


var employee = new Employee("Adam", "Kuliczkowski", "23");

while (true)
{
    Console.WriteLine("Aby zakończyć ocenę wpisz: q ");
    Console.WriteLine("Podaj kolejną ocenę");

    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Surname} Lat {employee.Age}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Final {statistics.AverageLetter}");