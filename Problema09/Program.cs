Console.WriteLine("Ingresa un año:");
int año = int.Parse(Console.ReadLine()!);

if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
{
    Console.WriteLine($"El año {año} es bisiesto.");
}
else
{
    Console.WriteLine($"El año {año} no es bisiesto.");
}