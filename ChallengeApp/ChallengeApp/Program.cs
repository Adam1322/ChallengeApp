using ChallengeApp;

Console.WriteLine("Witamy w programie oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Podaj oceny pracownika i kierownika. Żeby zakończyć proces naciśnij 'q'");
Console.WriteLine(" ");

var supervisor = new Supervisor("Tomasz", "Bąk", "50");
var employee = new Employee("Adam", "Kuliczkowski", "23");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę kierownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try { supervisor.AddGrade(input); }
    catch (Exception exception) { Console.WriteLine($"Exception catched:{exception.Message}"); }
}
var StatisticsEmployee = employee.GetStatistics();
var StatisticsSupervior = supervisor.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Pracownik {employee.Name} {employee.Surname} wiek : {employee.Age} lat");
Console.WriteLine();
Console.WriteLine($"Ocena średnia: {StatisticsEmployee.Average:N2}");
Console.WriteLine($"Ocena minimalna: {StatisticsEmployee.Min}");
Console.WriteLine($"Ocena maksymalna: {StatisticsEmployee.Max}");
Console.WriteLine($"Ocena końcowa: {StatisticsEmployee.AverageLetter}");

Console.WriteLine();
Console.WriteLine($"Kierownik {supervisor.Name} {supervisor.Surname} wiek : {supervisor.Age} lat");
Console.WriteLine();
Console.WriteLine($"Ocena średnia: {StatisticsSupervior.Average:N2}");
Console.WriteLine($"Ocena minimalna: {StatisticsSupervior.Min}");
Console.WriteLine($"Ocena maksymalna: {StatisticsSupervior.Max}");
Console.WriteLine($"Ocena końcowa: {StatisticsSupervior.AverageLetter}");