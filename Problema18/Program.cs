
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su estatura en metros: ");
        double estatura = double.Parse(
            Console.ReadLine()!.Replace(',', '.'),
            CultureInfo.InvariantCulture
        );

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("¿Está acompañado por un adulto? (si/no): ");
        string respuesta = Console.ReadLine()!.ToLower();

        bool acompanado = respuesta == "si" || respuesta == "sí";

        if (estatura >= 1.40 && (edad >= 12 || acompanado))
        {
            Console.WriteLine("Puede ingresar a la montaña rusa");
        }
        else
        {
            Console.WriteLine("No puede ingresar a la montaña rusa");
        }
    }
}
