object dato = "Hola mundo";

        if (dato is string texto)
        {
            Console.WriteLine(
                $"Texto de {texto.Length} caracteres");
        }
        else if (dato is int entero)
        {
            Console.WriteLine($"Entero: {entero}");
        }
        else if (dato is double decimalNumero)
        {
            Console.WriteLine($"Decimal: {decimalNumero}");
        }
        else if (dato is bool booleano)
        {
            Console.WriteLine($"Booleano: {booleano}");
        }
        else
        {
            Console.WriteLine("Tipo no reconocido");
        }