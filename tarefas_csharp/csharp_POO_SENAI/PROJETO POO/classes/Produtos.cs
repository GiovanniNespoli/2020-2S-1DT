using System;
using System.Collections.Generic;

namespace PROJETO_POO.classes
{
    public class Produtos
    {
        private int Codigo { get;  set;}
        private string NomeDoProduto {get; set;}
        private float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        Marca Marca = new Marca();
        Usuario CadastradoPor = new Usuario();
        List<Produtos> ListaDeProdutos = new List<Produtos>();

        public void Cadastrar()
        {
            Produtos novoProduto = new Produtos();

            Console.WriteLine("Insira o codigo do item a ser adicionado: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do item a ser adicionado: ");
            novoProduto.NomeDoProduto = Console.ReadLine();

            Console.WriteLine("Insira o preço a ser adicionado: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.Marca = Marca.cadastrar();

            novoProduto.CadastradoPor = new Usuario();

            novoProduto.DataCadastro = DateTime.UtcNow;

            ListaDeProdutos.Add(novoProduto);
        }                

        public void listar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(Produtos x in ListaDeProdutos)
            {
                Console.WriteLine($"Codigo: {x.Codigo}");
                Console.WriteLine($"Nome: {x.NomeDoProduto}");
                Console.WriteLine($"Preço: {x.Preco}");
                Console.WriteLine($"Data: {x.DataCadastro}");
                Console.WriteLine($"Marca: {x.Marca.NomeMarca}");
                Console.WriteLine($"Usuário: {x.CadastradoPor.Nome}");
            }
            Console.ResetColor();
        }

        public void Deletar(int cod)
        {
            Console.WriteLine("Insira o codigo a ser deletado: ");
            cod = int.Parse(Console.ReadLine());
            
            Produtos delet = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(delet);
        }
    }
}