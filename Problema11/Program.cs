
using System;

enum Semaforo
{
    Rojo,
    Amarillo,
    Verde
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el color (Rojo, Amarillo o Verde): ");
        string color = Console.ReadLine()!.ToLower();

        if (Enum.TryParse(color, true, out Semaforo estado))
        {
            switch (estado)
            {
                case Semaforo.Rojo:
                    Console.WriteLine("Deténgase");
                    break;

                case Semaforo.Amarillo:
                    Console.WriteLine("Precaución, prepárese para detenerse");
                    break;

                case Semaforo.Verde:
                    Console.WriteLine("Avance");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Color no válido");
        }
    }
}
