
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el peso en kg: ");
        double peso = double.Parse(
            Console.ReadLine()!.Replace(',', '.'),
            CultureInfo.InvariantCulture
        );

        Console.Write("Ingrese la estatura en metros: ");
        double estatura = double.Parse(
            Console.ReadLine()!.Replace(',', '.'),
            CultureInfo.InvariantCulture
        );

        if (peso <= 0 || estatura <= 0)
        {
            Console.WriteLine("El peso y la estatura deben ser mayores que cero");
            return;
        }

        double imc = peso / (estatura * estatura);

        Console.WriteLine($"IMC: {imc:F1}");

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }
    }
}
