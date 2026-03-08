Console.WriteLine("------ Verificación de Múltiplos ------ ");

 Console.Write("Ingrese primer número: ");
 int number1 = int.Parse(Console.ReadLine()!);
 Console.Write("Ingrese segundo número: ");
 int number2 = int.Parse(Console.ReadLine()!);

  //verificacion de multiplo: number2 % number1 == 0
  if (number1 != 0 && number2 % number1 == 0)
  {
     Console.WriteLine($" Resultado: {number2}, es multiplo de: {number1} ");
  }
  else
  {
     Console.WriteLine($" Resultado: {number2}, no es multiplo de: {number1} ");
}