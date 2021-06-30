using System;

namespace aprendendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o 1º número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o 2º número:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar? ([a]adição | [s]subtração | [m]multiplicação | [d]divisão)");
            string op = Console.ReadLine();

            float resultado = 0;

            switch(op){

                case "a" :
                resultado = num1 + num2;
                break;

                case "s":
                resultado = num1 - num2;
                break;

                case "m":
                resultado = num1 * num2;
                break;

                case "d":
                resultado = num1 / num2;
                break;

                default:
                op = "invalida";
                Console.WriteLine("Sua operação é inválida");
                break;
            }

            if( op != "invalida"){
                Console.WriteLine("");

            Console.Write("sua conta deu ");
            Console.WriteLine(resultado);
            }
            
        }
    }
}
