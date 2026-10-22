
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine()!);

        if (dia >= 1 && dia <= 5)
        {
            Console.WriteLine("Día hábil");
        }
        else if (dia == 6 || dia == 7)
        {
            Console.WriteLine("Fin de semana");
        }
        else
        {
            Console.WriteLine("Día inválido");
        }
    }
}
