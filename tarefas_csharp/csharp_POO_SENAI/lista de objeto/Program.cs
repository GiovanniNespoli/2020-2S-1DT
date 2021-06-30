using System;
using System.Collections.Generic;
using lista_de_objeto.classes;

namespace lista_de_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "tenis" , 50.50F));
            produtos.Add(new Produto(2, "chinelo" , 20F));
            produtos.Add(new Produto(3,"relogio", 1000.50F));

            foreach(Produto x in produtos)
            {
                Console.WriteLine($"CODIGO: {x.Codigo} / PRODUTO: {x.Nome} / PRECO: {x.Preco} R$");
            }

            Produto celular = new Produto();
            celular.Codigo = 4;
            celular.Nome = "A01";
            celular.Preco = 2000F;

            produtos.Add(celular);

            Console.WriteLine("");
            Console.WriteLine("Item novo adicionado");
            Console.WriteLine("");

            foreach(Produto x in produtos)
            {
                Console.WriteLine($"CODIGO: {x.Codigo} / PRODUTO: {x.Nome ?? "vazio"} / PRECO: {x.Preco} R$");
            }
            Console.WriteLine("Deleta um por codigo ae");
            int resp = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            produtos.RemoveAll(y => y.Codigo == resp);

            Console.WriteLine("Item deletado");
            Console.WriteLine("");

            foreach(Produto x in produtos)
            {
                Console.WriteLine($"CODIGO: {x.Codigo} / PRODUTO: {x.Nome} / PRECO: {x.Preco} R$");
            }

        }
    }
}
