var name = "Adam";
bool kobieta = false;
var age = 22;

if (kobieta == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Ewa poniżej 30 lat");
    }
}  
else if (age < 18 && kobieta == true)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
Console.WriteLine("Żadna z tych odpowiedźi");