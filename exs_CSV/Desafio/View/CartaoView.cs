using System;
using System.Collections.Generic;
using Model;

namespace View
{
    public class CartaoView
    {
        public Cartao perguntas()
        {

            string rep = "";
            Cartao car = new Cartao();

            do{


            Console.WriteLine($"Nome completo:");
            car.Nome = Console.ReadLine();
            
            Console.WriteLine($"Número do cartão:");
            car.NumeroDoCartao = float.Parse( Console.ReadLine() );

            Console.WriteLine($"CVV do cartão:");
            car.CVV = int.Parse( Console.ReadLine());
            
            Console.WriteLine($"Quatro ultimos digitos do cartão:");
            car.quatroDig = int.Parse(Console.ReadLine());

            Console.WriteLine($"");

            Console.WriteLine($"Veifique as informações:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{car.Nome}");
            Console.WriteLine($"{car.NumeroDoCartao}");
            Console.WriteLine($"{car.CVV}");
            Console.WriteLine($"{car.quatroDig}");
            Console.ResetColor();

            Console.WriteLine($"");

            Console.WriteLine($"Estão corretas? (s/n)");
            string rr = Console.ReadLine();
            
            if(rr == "n")
            {
                rep = "b";
            }
            else if(rr == "s")
            {
                Console.WriteLine($"Cadastro concluido");
                rep = "a";
            }

            
            }while(rep == "b");

            return car;
        }

        public void list( List<Cartao> x )
        {
            foreach( var y in x)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"NOME: {y.Nome} || CARTÃO: {y.NumeroDoCartao} || CVV: {y.CVV} || 4 ULTIMOS DÍGITOS: {y.quatroDig}");
                Console.ResetColor();
            }
        }

    }
}