using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa el nivel de carga: ");
        int nivelCarga = int.Parse(Console.ReadLine()!);

        if (nivelCarga < 15)
        {
            Console.WriteLine("Bateria baja: Conecte el cargador");
            Console.WriteLine($"Tu nivel de carga es: {nivelCarga}%");
        }

        else
        {
            Console.WriteLine($"Tu nivel de carga es: {nivelCarga}%");
        }
    }
}