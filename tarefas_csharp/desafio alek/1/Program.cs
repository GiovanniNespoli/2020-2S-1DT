using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bem vindo ao conversor de idade");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            
            Console.WriteLine("O que deseja converter? (meses [M] / dias [D] / horas [H] / minutos [m])");
            string resp = Console.ReadLine();
            Console.WriteLine("--------------------------------");


            int mes = idade * 12;
            double dias = idade * 365.25;
            int horas = idade * 8766;
            int minutos = idade * 525960;

            switch(resp){
                case "M":
                Console.Write("Você viveu ");
                Console.Write(mes );
                Console.WriteLine(" meses ");
                break;

                case "D":
                Console.Write("Você viveu ");
                Console.Write(dias );
                Console.WriteLine(" dias");
                break;

                case "H":
                Console.Write("Você viveu ");
                Console.Write(horas );
                Console.WriteLine(" horas");
                break;

                case "m":
                Console.Write("Você viveu ");
                Console.Write(minutos );
                Console.WriteLine(" minutos ");
                break;
                
                default:
                Console.WriteLine("selecione uma resposta válida");
                break;
            }
        }
    }
}
