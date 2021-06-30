using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento:");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            int idade = 2020 - ano;
            double semanas = idade * 52.1786;

            Console.Write("Você tem ");
            Console.Write(idade);
            Console.WriteLine(" anos");

            Console.WriteLine("e");

            Console.Write("Viveu ");
            Console.Write(semanas);
            Console.WriteLine(" semanas");

        }
    }
}
