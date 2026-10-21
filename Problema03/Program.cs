using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("====MENU====");
        Console.WriteLine("Digite un numero del menu: ");
        Console.WriteLine("1. Consultar Saldo");
        Console.WriteLine("2. Retirar Dinero");
        Console.WriteLine("3. Depositar");
        Console.WriteLine("4. Salir");
        int numero = int.Parse(Console.ReadLine()!);

        switch (numero)
        {
            case 1:
                Console.WriteLine("Consultando saldo...");
                break;
            case 2:
                Console.WriteLine("Has seleccionado: Retirar");
                break;
            case 3:
                Console.WriteLine("Has seleccionado: Depositar");
                break;
            case 4:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}