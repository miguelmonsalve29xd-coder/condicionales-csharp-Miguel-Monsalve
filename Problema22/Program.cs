
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la operación (+, -, *, /): ");
        string operador = Console.ReadLine()!;

        try
        {
            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado: {numero1 + numero2}");
                    break;

                case "-":
                    Console.WriteLine($"Resultado: {numero1 - numero2}");
                    break;

                case "*":
                    Console.WriteLine($"Resultado: {numero1 * numero2}");
                    break;

                case "/":
                    if (numero2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    Console.WriteLine($"Resultado: {(double)numero1 / numero2}");
                    break;

                default:
                    throw new InvalidOperationException(
                        "Operador no soportado");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir entre cero");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
