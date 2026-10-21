using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite su numero: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero >= 16)
        {
            Console.WriteLine("puede votar");
        }
        else
        {
            Console.WriteLine("no puede votar");
        }
    }
}