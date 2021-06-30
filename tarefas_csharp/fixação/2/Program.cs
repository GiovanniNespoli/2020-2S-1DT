using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual vai ser chefia? [G] Gasolina / [A] Alcool");
            Console.ForegroundColor = ConsoleColor.Gray;
            string comb = Console.ReadLine();

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Quantos litros serão?");
            Console.ForegroundColor = ConsoleColor.Gray;    
            int litro = int.Parse(Console.ReadLine());

            double gas1 ( double litro)
            {
              double gas =  5.3 - 0.2;
              double total = gas * litro;

              return total;
            }
            double gas2 ( double litro)
            {
                double gas = 5.2 - 0.31;
                double total = gas * litro;

                return total;
            }
            double al1 ( double litro)
            {
                double al = 4.9 * litro * 0.97;

                return al;
            }
            double al2 ( double litro)
            {
                double al = 4.9 * litro * 0.95;

                return al;
            }

            Console.WriteLine("");
            
              switch(comb)
              {
                  case "G":
                  if( litro <= 20)
                  {
                      Console.ForegroundColor = ConsoleColor.Green;
                      Console.WriteLine($"O total a se pagar com o desconto, foi de {gas1(litro)}");
                  } else if ( litro > 20)
                  {
                      Console.ForegroundColor = ConsoleColor.Green;
                      Console.WriteLine($"O total a se pagar com o desconto, foi de {gas2(litro)}");
                  }
                  break;

                  case "A":
                  if( litro <= 20)
                  {
                      Console.WriteLine($"O total a se pagar com o desconto, foi de {al1(litro)}");
                  } else if ( litro > 20)
                  {
                      Console.WriteLine($"O total a se pagar com o desconto, foi de {al2(litro)}");
                  }
                  break;
              }
            }
        }
    }
