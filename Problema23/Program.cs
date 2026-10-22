
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el usuario: ");
        string usuario = Console.ReadLine()!;

        if (usuario != "aprendiz")
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.Write("Ingrese la contraseña: ");
            string contrasena = Console.ReadLine()!;

            if (contrasena != "Sena2026")
            {
                Console.WriteLine("Contraseña incorrecta");
            }
            else
            {
                Console.WriteLine("Bienvenido");
            }
        }
    }
}
