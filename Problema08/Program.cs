Console.Write("Ingrese una letra minúscula: ");
        string entrada = Console.ReadLine()!.ToLower();

        if (entrada.Length != 1 ||
            entrada[0] < 'a' || entrada[0] > 'z')
        {
            Console.WriteLine("No es una letra");
        }
        else if ("aeiou".Contains(entrada[0]))
        {
            Console.WriteLine("Es una vocal");
        }
        else
        {
            Console.WriteLine("Es una consonante");
        }