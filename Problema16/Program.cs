
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la coordenada X: ");
        double x = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la coordenada Y: ");
        double y = double.Parse(Console.ReadLine()!);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("El dron está en el origen");
        }
        else if (x == 0)
        {
            Console.WriteLine("El dron está sobre el eje Y");
        }
        else if (y == 0)
        {
            Console.WriteLine("El dron está sobre el eje X");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Primer cuadrante");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Segundo cuadrante");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Tercer cuadrante");
        }
        else
        {
            Console.WriteLine("Cuarto cuadrante");
        }
    }
}
