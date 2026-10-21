Console.WriteLine("Ingresa cualquier número: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero == 0)
{
    Console.WriteLine("El número es cero");
}
else if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}
else
{
    Console.WriteLine("El número es negativo");
}