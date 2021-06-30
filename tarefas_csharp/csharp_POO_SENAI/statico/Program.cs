using System;


namespace statico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para qual moeda será convertida?");
            Console.WriteLine("[a] DOLAR");
            Console.WriteLine("[b] EURO");
            string resp = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira o valor(R$) a ser convertido: ");
            int va = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch(resp)
            {
                case "a":
                Console.WriteLine("Dolar --> Reais [a]");
                Console.WriteLine("Reais --> Dolar [b]");
                string rr = Console.ReadLine();

                Console.WriteLine("");

                if(rr == "a")
                {
                    Console.WriteLine($"{va}$ para reais = {troca.dolarReais(va)}R$");
                } else
                {
                     Console.WriteLine($"{va}R$ para dolar = {troca.reaisDolar(va)}$");
                }
                break;

                case "b":
                Console.WriteLine("Euro --> Reais [a]");
                Console.WriteLine("Reais --> Euro [b]");
                string r = Console.ReadLine();

                Console.WriteLine("");

                if(r == "a")
                {
                    Console.WriteLine($"{va}€ para reais = {troca.euroReais(va)}R$");
                } else
                {
                     Console.WriteLine($"{va}R$ para euro = {troca.reaisEuro(va)}€");
                }
                break;
            }
        }
    }
}
