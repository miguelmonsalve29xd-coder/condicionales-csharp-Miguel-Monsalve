
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de la compra: ");
        decimal compra = decimal.Parse(
            Console.ReadLine()!.Replace(',', '.'),
            CultureInfo.InvariantCulture
        );

        Console.Write("¿Es cliente frecuente? (si/no): ");
        string respuesta = Console.ReadLine()!.ToLower();

        bool frecuente = respuesta == "si" || respuesta == "sí";
        decimal descuento = 0;

        if (compra >= 500000)
        {
            descuento = 15;
        }
        else if (compra >= 200000)
        {
            descuento = 10;
        }
        else if (compra >= 100000)
        {
            descuento = 5;
        }

        if (frecuente && compra >= 100000)
        {
            descuento += 5;
        }

        decimal valorDescuento = compra * descuento / 100;
        decimal totalPagar = compra - valorDescuento;

        Console.WriteLine($"Valor de la compra: ${compra:N0}");
        Console.WriteLine($"Descuento total: {descuento}%");
        Console.WriteLine($"Total a pagar: ${totalPagar:N0}");
    }
}
