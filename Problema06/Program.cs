Console.WriteLine("piedra, papel o tijera");

Console.WriteLine("Jugador 1: Ingresa tu elección (piedra, papel o tijera): ");
string jugador1 = Console.ReadLine()!.ToLower();

Console.WriteLine("Jugador 2: Ingresa tu elección (piedra, papel o tijera): ");
string jugador2 = Console.ReadLine()!.ToLower();

if (jugador1 == jugador2)
{
    Console.WriteLine("Empate");
}

else if ((jugador1 == "piedra" && jugador2 == "tijera") ||
         (jugador1 == "papel" && jugador2 == "piedra") ||
         (jugador1 == "tijera" && jugador2 == "papel"))
{
    Console.WriteLine("Jugador 1 gana");
}
else
{
    Console.WriteLine("Jugador 2 gana");
}