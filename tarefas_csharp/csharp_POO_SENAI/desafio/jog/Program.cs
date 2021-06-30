using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            jogador jog = new jogador();
            string resp = "";
        do{

            Console.Write("Nome: ");
            jog.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Selecione a sua posição");
            Console.WriteLine("GOLEIRO [1]");
            Console.WriteLine("DEFENSOR [2]");
            Console.WriteLine("MEIO - CAMPO [3]");
            Console.WriteLine("ATACANTE [4]");
            jog.Posicao = Console.ReadLine();

            if( jog.Posicao	== "1")
            {
                jog.Posicao = "goleiro";
            }
            else if ( jog.Posicao == "2")
            {
                jog.Posicao = "meio-campo";
            }
            else if( jog.Posicao == "3")
            {
                jog.Posicao = "defesa";
            }
            else if( jog.Posicao == "4")
            {
                jog.Posicao = "atacante";
            }

            Console.WriteLine("");

            Console.Write("Ano de nascimento: ");
            jog.AnoDeNas = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Nacionalidade: ");
            jog.Nacionalidade = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Altura (cm): ");
            jog.Altura = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Peso (kg): ");
            jog.Peso = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("========================================================");

            Console.WriteLine("");

            jog.info();

            Console.WriteLine("");

            Console.WriteLine("Sua informações estão corretas? (y/n)");
            resp = Console.ReadLine();


        }while(resp == "n");

            Console.WriteLine("");

            jog.apo(jog.Posicao);
        }
    }
}
