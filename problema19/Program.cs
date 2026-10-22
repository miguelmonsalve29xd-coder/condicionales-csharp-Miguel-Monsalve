Console.Write("Ingrese la velocidad en km/h: ");
int velocidad = int.Parse(Console.ReadLine()!);

if (velocidad < 0)
    {
        Console.WriteLine("Velocidad inválida");
    }
else if (velocidad <= 50)
    {
        Console.WriteLine("Sin infracción");
    }
else if (velocidad <= 70)
    {
    Console.WriteLine("Multa leve");
    }
else if (velocidad <= 90)
    {
    Console.WriteLine("Multa grave");
    }
else
    {
    Console.WriteLine("Multa gravísima e inmovilización");
    }