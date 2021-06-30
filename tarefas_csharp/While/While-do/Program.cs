using System;

namespace while_do
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            string resposta ="";

            do{
                Console.WriteLine("insira o 1º número: ");
                int numb1 = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("insira o 2º número: ");
                int numb2 = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.Write("Selecione qual operção você deseja operar:");
                Console.WriteLine("(+) / (-) / (x) / (÷)");
                resp = Console.ReadLine();

                switch(resp){

                    case "+":
                    Console.WriteLine($"{numb1} + {numb2} = {numb1 + numb2}");
                    Console.WriteLine("");
                    Console.WriteLine("deseja repetir? (y/n)");
                    resposta = Console.ReadLine();
                    break;
                    
                    case "-":
                    Console.WriteLine($"{numb1} - {numb2} = {numb1 - numb2}");
                    Console.WriteLine("deseja repetir? (y/n)");
                    resposta = Console.ReadLine();
                    
                    break;

                    case "x":
                    Console.WriteLine($"{numb1} x {numb2} = {numb1 * numb2}");
                    Console.WriteLine("deseja repetir? (y/n)");
                    resposta = Console.ReadLine();
                    break;

                    case "÷":
                    Console.WriteLine($"{numb1} ÷ {numb2} = {numb1 / numb2}");
                    Console.WriteLine("deseja repetir? (y/n)");
                    resposta = Console.ReadLine();
                    break;

                    default:
                    Console.WriteLine("Isto não é uma resposta válida, deseja repetir? (y/n)");
                    resposta = Console.ReadLine();
                    break;

                }

            } while( resposta == "y");
            
        }
    }
}
