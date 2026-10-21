
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine()!);

        int mayor = numero1 > numero2 ? numero1 : numero2;

        Console.WriteLine($"El mayor es {mayor}");
    }
}
