
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el índice de calidad del aire (ICA): ");
        int ica = int.Parse(Console.ReadLine()!);

        if (ica < 0)
        {
            Console.WriteLine("ICA inválido");
        }
        else if (ica <= 50)
        {
            Console.WriteLine("Buena");
        }
        else if (ica <= 100)
        {
            Console.WriteLine("Moderada");
        }
        else if (ica <= 150)
        {
            Console.WriteLine("Dañina para grupos sensibles");
        }
        else if (ica <= 200)
        {
            Console.WriteLine("Dañina");
        }
        else
        {
            Console.WriteLine("Muy dañina");
        }
    }
}
