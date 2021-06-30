using System;
using System.Collections.Generic;
using Model;

namespace View
{
    public class ProdutoView
    {
        public void Write( List<Produto> produtos)
        {
            foreach( var x in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Nome: {x.Nome} // Código: {x.Codigo} // Preço: {x.Preco}R$");
            }
        }

        public Produto quest()
        {
            Produto prod = new Produto();

            Console.WriteLine($"Digite o nome:");
            prod.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite o código:");
            prod.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o preço:");
            prod.Preco = float.Parse(Console.ReadLine());

            return prod;
        }
        
    }
}