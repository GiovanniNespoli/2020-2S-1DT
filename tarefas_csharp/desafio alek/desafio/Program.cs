using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a idade do deu filho");
            int idade = int.Parse(Console.ReadLine());

            if( idade >=5 && idade <=7){
                Console.WriteLine(" Seu filho entrou para a categoria INFANTIL A ");
            }
            }
        }
    }

