var numberString = String.Empty;
do
{
    Console.WriteLine("Ingrese número: ");
    numberString = Console.ReadLine();

    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, Es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, Es impar");
        }

    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberInt}, no es un número entero.");
    }

} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game over");