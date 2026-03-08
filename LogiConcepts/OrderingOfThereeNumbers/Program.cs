Console.WriteLine("Ingrese tres número diferentes: ");

     Console.Write("Ingrese primer número: ");
     double number1 = double.Parse(Console.ReadLine()!);
     Console.Write("Ingrese segundo número: ");
     double number2 = double.Parse(Console.ReadLine()!);
     Console.Write("Ingrese tercero número: ");
     double number3 = double.Parse(Console.ReadLine()!);

    double mayor, medio, menor;

if (number1 > number2 && number1 > number3)
    mayor = number1;
else if (number2 > number1 && number2 > number3)
    mayor = number2;
else
    mayor = number3;
if (number1<number2 && number1 < number3) 
    menor = number1;
else if (number2<number1 && number2 < number3) menor = number2;
    else 
    menor = number3;

    medio = number1 + number2 + number3 - mayor - menor;
{
    Console.WriteLine($"----------Resultados-----------");
    Console.WriteLine($"El número mayor es: {mayor} ");
    Console.WriteLine($"El número medio es: {medio} ");
    Console.WriteLine($"El número menor es: {menor} ");
}
      
