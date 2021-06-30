using System.Collections.Generic;
using System;

namespace POO_interface.classe
{
    public class Carrinho : Icarrinho
    {

        List<Produto> carrinho = new List<Produto>();
        
        public void Alterar(int cod, Produto novo)
        {
            var alterar = carrinho.Find(x => x.Codigo == cod);
            alterar.Codigo = novo.Codigo;
            alterar.Nome = novo.Nome;
            alterar.Preco= novo.Preco;
        }

        public void Cadastrar(Produto x)
        {
            carrinho.Add(x);
        }

        public void delete(int cod)
        {
            Produto proDelete = carrinho.Find(x => x.Codigo == cod);

            if( carrinho != null)
            {
                carrinho.Remove(proDelete);
            }
        }

        public void Listar()
        {
            Console.WriteLine("");
            Console.WriteLine("Sua lista: ");
            foreach(Produto x in carrinho)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"CODIGO: {x.Codigo} / NOME: {x.Nome} / PREÇO: {x.Preco}R$");
                Console.ResetColor();
            }
        }

        public void precoTotal()
        {
            int Valor = 0;
            foreach(Produto x in carrinho)
            {
                Valor += x.Preco;
            }
            Console.WriteLine($"Preço total: {Valor}R$");
        }

        public void produtos(Produto a, Produto b, Produto c)
        {
            Console.WriteLine("Lista de produtos da loja");
            Console.WriteLine($"CODIGO: {a.Codigo} / NOME: {a.Nome} / PREÇO: {a.Preco}R$");
            Console.WriteLine($"CODIGO: {b.Codigo} / NOME: {b.Nome} / PREÇO: {b.Preco}R$");
            Console.WriteLine($"CODIGO: {c.Codigo} / NOME: {c.Nome} / PREÇO: {c.Preco}R$");
        }
    }
}