using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string senha = "";

            do{
             Console.ForegroundColor = ConsoleColor.Gray;
             Console.WriteLine("Insira seu nome:");
             Console.ForegroundColor = ConsoleColor.Blue;
             nome = Console.ReadLine();

             Console.WriteLine("");

             Console.ForegroundColor = ConsoleColor.Gray;
             Console.WriteLine("Insira sua senha:");
             Console.ForegroundColor = ConsoleColor.Blue;
             senha = Console.ReadLine();

             Console.WriteLine("");

             if( senha != nome){
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("sucesso");

             } else if( senha == nome){
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Senha ou nome inválida");
                 Console.WriteLine("");
             }
            } while(senha == nome);
        }
    }
}
