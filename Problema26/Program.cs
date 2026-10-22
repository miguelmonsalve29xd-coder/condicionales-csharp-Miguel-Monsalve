
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la categoría del vehículo (M, A, B o C): ");
        string categoria = Console.ReadLine()!.ToUpper();

        try
        {
            decimal tarifa;

            switch (categoria)
            {
                case "M":
                    tarifa = 0;
                    break;

                case "A":
                    tarifa = 12000;
                    break;

                case "B":
                    tarifa = 25000;
                    break;

                case "C":
                    tarifa = 38000;
                    break;

                default:
                    throw new Exception("Categoría desconocida");
            }

            Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa:N0}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
