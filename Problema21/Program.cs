
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de artículos: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        string mensaje = cantidad == 1
            ? "Hay 1 artículo en el carrito"
            : $"Hay {cantidad} artículos en el carrito";

        Console.WriteLine(mensaje);
    }
}
