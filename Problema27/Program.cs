
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el día de la semana: ");
        string dia = Console.ReadLine()!.ToLower();

        Console.Write("¿Es estudiante? (si/no): ");
        string respuesta = Console.ReadLine()!.ToLower();

        bool estudiante = respuesta == "si" || respuesta == "sí";
        int precio;

        if (dia == "martes")
        {
            precio = 7000;
        }
        else if (dia == "sabado" || dia == "sábado" ||
                 dia == "domingo")
        {
            precio = 15000;
        }
        else if (estudiante)
        {
            precio = 9000;
        }
        else
        {
            precio = 12000;
        }

        Console.WriteLine($"Precio de la entrada: ${precio:N0}");
    }
}
