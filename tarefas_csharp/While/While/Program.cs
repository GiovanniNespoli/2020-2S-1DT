using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja receber um bem-vindo? (y/n) ");
            string resp = Console.ReadLine();

            int contador = 0;

            while(resp == "y"){
                Console.WriteLine("Bem-Vindo");

                contador ++;

                Console.WriteLine("Deseja Receber outro? (y/n) ");
                string rr = Console.ReadLine();

                if(rr == "n"){
                    Console.WriteLine($"Ok então, você recebeu {contador} bem vindos, até a proxima.");
                    break;
                }
            }
            {
                
            }
        }
    }
}
