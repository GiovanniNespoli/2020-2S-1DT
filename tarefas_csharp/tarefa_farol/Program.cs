using System;

namespace farol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma cor do Farol ");
            Console.WriteLine("");
            Console.WriteLine("[r]Red | [y]yellow | [g]green ");
            string answer = Console.ReadLine();

Console.WriteLine("");

            switch(answer){

                case "r":
                Console.WriteLine("Pare!!");
                break;

                case "y":
                Console.WriteLine("Diminua a velociade");
                break;

                case "g":
                Console.WriteLine("Avance");
                break;

                default:
                Console.WriteLine("isto não é uma cor de farol");
                Console.WriteLine("");
                Console.WriteLine("Porfavor, escolha uam cor de farol");
                Console.WriteLine("");
                break;
            }

            }
        }
    
}
