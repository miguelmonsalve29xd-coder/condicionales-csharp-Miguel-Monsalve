Console.Write("Ingrese el código del país: ");
    string codigo = Console.ReadLine()!.ToUpper();

    switch (codigo)
    {
        case "CO":
            Console.WriteLine("Colombia");
            break;

        case "MX":
            Console.WriteLine("México");
            break;

        case "AR":
            Console.WriteLine("Argentina");
            break;

        case "PE":
            Console.WriteLine("Perú");
            break;

        case "CL":
            Console.WriteLine("Chile");
            break;

        default:
            Console.WriteLine("País no registrado");
            break;
        }