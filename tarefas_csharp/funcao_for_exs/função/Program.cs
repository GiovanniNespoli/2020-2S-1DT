using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int soma (int num1,int num2 )
            {
                int resultado = num1 + num2;

                return resultado;
            }

            Console.WriteLine("Declare o 1º numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Declare o 2º numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write($"O resultado é ");
            Console.WriteLine(soma(num1, num2));
        }   
    }
}
