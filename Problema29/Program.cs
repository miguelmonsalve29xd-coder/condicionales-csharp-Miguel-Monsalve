
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el rol (admin, instructor, aprendiz): ");
        string rol = Console.ReadLine()!.ToLower();

        Console.Write("Ingrese la hora (0 a 23): ");
        int hora = int.Parse(Console.ReadLine()!);

        if (hora < 0 || hora > 23)
        {
            Console.WriteLine("Hora inválida");
        }
        else if (rol == "admin")
        {
            Console.WriteLine("Acceso permitido");
        }
        else if (rol == "instructor" && hora >= 6 && hora <= 21)
        {
            Console.WriteLine("Acceso permitido");
        }
        else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}
