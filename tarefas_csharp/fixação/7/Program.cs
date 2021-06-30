using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int [16];

            for( int i = 1; i < 16 ; i++)
            {
                Console.WriteLine($"Escreva um número:  ({16 - i} restante(s))");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for( int a = 15; a > 0; a--)
            {
                Console.WriteLine(num[a]);
                Console.WriteLine("");
            }
        }
    }
}
