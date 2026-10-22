
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la primera nota (0 a 100): ");
        double nota1 = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la segunda nota (0 a 100): ");
        double nota2 = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la tercera nota (0 a 100): ");
        double nota3 = double.Parse(Console.ReadLine()!);

        if (nota1 < 0 || nota1 > 100 ||
            nota2 < 0 || nota2 > 100 ||
            nota3 < 0 || nota3 > 100)
        {
            Console.WriteLine("Las notas deben estar entre 0 y 100");
            return;
        }

        double promedio = (nota1 + nota2 + nota3) / 3;
        string letra;
        string comentario;

        if (promedio >= 90)
        {
            letra = "A";
            comentario = "Desempeño excelente";
        }
        else if (promedio >= 80)
        {
            letra = "B";
            comentario = "Buen desempeño, sigue así";
        }
        else if (promedio >= 70)
        {
            letra = "C";
            comentario = "Buen desempeño, sigue así";
        }
        else if (promedio >= 60)
        {
            letra = "D";
            comentario = "Aprobado, refuerza los temas";
        }
        else
        {
            letra = "F";
            comentario = "Debe presentar plan de mejoramiento";
        }

        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Calificación: {letra}");
        Console.WriteLine(comentario);

        if (promedio >= 60)
        {
            Console.WriteLine("Estado: Aprobado");
        }
        else
        {
            Console.WriteLine("Estado: Reprobado");
        }

        if (promedio == 100)
        {
            Console.WriteLine("¡Mención de honor!");
        }
    }
}
