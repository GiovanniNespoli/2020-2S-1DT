using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            double preço1;

            do{
                int quantos;

            string[] produtos = {"Colher R$1,0","Garfo R$1,5"};
            
            Console.ForegroundColor = ConsoleColor.Blue;
            for( int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("------------");
                Console.WriteLine(produtos[i]);
            }

          double cuie1( double quantos )
            {
                double total = quantos * 0.98;
                return total;
            }
          double cuie2 ( double quantos )
          {
              double total = quantos * 0.97;
              return total;
          }
         double cuie3 ( double quantos )
         {
             double total = quantos * 0.95;
             return total;
         }
         double garfo1 ( double quantos)
         {
             double total = preço1 * 0.98;
             return total;
         }
         double garfo2 ( double quantos )
         {
             double total = preço1 * 0.97;
             return total;
         }
         double garfo3 ( double quantos )
         {
             double total = preço1 * 0.95;
             return total;
         }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");

            Console.WriteLine("Escolha o produto que deseja comprar:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string pro = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Quantos deseja levar:");
            Console.ForegroundColor = ConsoleColor.Gray;
            quantos = int.Parse(Console.ReadLine());

            preço1 = quantos * 1.5;

            switch(pro)
            {
                case "Colher":
                if( quantos <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Você pagaria R${quantos}, mas com a promoção ficará R${cuie1(quantos)}");
                    Console.WriteLine("");
                     Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n)");
                     resp = Console.ReadLine();

                } else if ( quantos <=10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"Você pagaria R${quantos}, mas com a promoção ficará R${cuie2(quantos)}"); 
                    Console.WriteLine("");
                     Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n)");
                     resp = Console.ReadLine();

                } else if ( quantos >10){
                     Console.ForegroundColor = ConsoleColor.Blue;
                     Console.WriteLine($"Você pagaria R${quantos}, mas com a promoção ficrá R${cuie3(quantos)}");
                     Console.WriteLine("");
                      Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n)");
                     resp = Console.ReadLine();

                }
                break;

                case "Garfo":

                if( quantos <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Você pagaria R${preço1}, mas com a promoção ficará R${garfo1(quantos)}");
                    Console.WriteLine("");
                     Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n");
                     resp = Console.ReadLine();

                } else if ( quantos <=10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"Você pagaria R${preço1}, mas com a promoção ficará R${garfo2(quantos)}"); 
                    Console.WriteLine("");
                     Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n)");
                     resp = Console.ReadLine();

                } else if ( quantos >10){
                     Console.ForegroundColor = ConsoleColor.Blue;
                     Console.WriteLine($"Você pagaria R${preço1}, mas com a promoção ficrá R${garfo3(quantos)}");
                     Console.WriteLine("");
                      Console.ForegroundColor = ConsoleColor.Gray;

                     Console.WriteLine("Deseja comprar algo mais? (y/n)");
                     resp = Console.ReadLine();

                }
                break;

                default:
                Console.WriteLine("Selecione uma opção válida, deseja repetir? (y/n)");
                resp = Console.ReadLine();
                break;
            }
        }while( resp == "y");
       
    }
}
}