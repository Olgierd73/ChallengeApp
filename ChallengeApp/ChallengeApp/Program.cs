//zadanie domowe dzień 4
string name = "Ewa";
var age = 33;
bool isFemale = true;

if (isFemale)

{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa,lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30");
    }
}
else
{
    if (age >= 18)
    {
        Console.WriteLine("Mężczyzna pełnoletni");
    }
    else 
    {
        Console.WriteLine("Mężczyzna niepełnoletni");
    }
}
        




