using IeapYear;


do
{
    var year = ConsoloExtension.GetInt("Ingrese año");

    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, SI es biciesto. ");
            }
            else
            {
                Console.WriteLine($"El año: {year}, NO es biciesto. ");
            }
        }
        else
        {
            Console.WriteLine($"El año: {year}, SI es biciesto. ");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year}, NO es biciesto. ");
    }

} while (true);

namespace IeapYear
{
    class ConsoloExtension
    {
        internal static int GetInt(string v)
        {
            throw new NotImplementedException();
        }
    }
}