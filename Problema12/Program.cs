
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("¿Tiene empleo? (si/no): ");
        string respuesta = Console.ReadLine()!.ToLower();

        bool tieneEmpleo = respuesta == "si" || respuesta == "sí";

        if (!tieneEmpleo)
        {
            Console.WriteLine("Crédito rechazado");
        }
        else
        {
            Console.Write("Ingrese sus ingresos mensuales: ");
            decimal ingresos = decimal.Parse(
                Console.ReadLine()!.Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            if (ingresos >= 2500000)
            {
                Console.WriteLine("Crédito alto aprobado");
            }
            else
            {
                Console.WriteLine("Crédito básico aprobado");
            }
        }
    }
}
