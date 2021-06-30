using System;

namespace POO_encapsulamento.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            masterCard num = new masterCard();

            string a = "";
            
            num.CVV = "123";

            num.Nome = "Giovanni Nespoli";

            Console.WriteLine($"Bem vindo {num.Nome}");

            Console.WriteLine("");
            
        do{
            Console.WriteLine("O que deseja acessar?");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Limite do cartão [1]");
            Console.WriteLine("Token do cartão [2]");
            Console.WriteLine("CVV do cartão [3]");
            Console.WriteLine("Sair [0]");
            a = Console.ReadLine();

            Console.WriteLine("");

            switch(a){

                case "1":
                Console.WriteLine($"Seu limite é de {num.Limite} R$");
                a = "repeat";
                Console.WriteLine("");
                break;

                case "2":
                Console.WriteLine($"Seu token é {num.Token}");
                a = "repeat";
                Console.WriteLine("");
                break;

                case "3":
                Console.WriteLine($"Seu CVV é {num.CVV}");
                a = "repeat";
                Console.WriteLine("");
                break;

                case "0":
                Console.WriteLine("Ok, tenha um bom dia!!");
                a = "b";
                Console.WriteLine("");
                break;

                default:
                Console.WriteLine("Selecione uma opção válida");
                a = "repeat";
                break;

            }


        }while(a == "repeat");
        }
    }
}
