using System;

namespace _20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for ( int i = 0; i < 3; i++)
            {
                if(senha != 123456){
                    Console.WriteLine("Senha invalida");
                    Console.WriteLine("");

                   
                    Console.WriteLine($"{3-i} chances restantes");
                    Console.WriteLine("");

                    Console.WriteLine("Insira novamente:");
                    senha = int.Parse(Console.ReadLine());

                } else if(senha == 123456){
                    Console.WriteLine("correto meu caro");
                }
            }
        }
    }
}
