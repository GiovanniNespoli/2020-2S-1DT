using System;
using metodos_construtores.classe;

namespace metodos_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            produto produto1 = new produto();

            Console.WriteLine($"Código = {produto1.Codigo} / Nome = {produto1.Nome ?? "vazio"} / Descrição = {produto1.Desc ?? "vazio"} / Estoque = {produto1.Estoque}");
        
            Console.WriteLine("");

            produto produto2 = new produto(2,2);

            Console.WriteLine($"Código = {produto2.Codigo} / Nome = {produto2.Nome ?? "vazio"} / Descrição = {produto2.Desc ?? "vazio"} / Estoque = {produto2.Estoque}");
        
            Console.WriteLine("");

            produto produto3 = new produto(3,"mouse","Isto é um mouse",3);

            Console.WriteLine($"Código = {produto3.Codigo} / Nome = {produto3.Nome ?? "vazio"} / Descrição = {produto3.Desc ?? "vazio"} / Estoque = {produto3.Estoque}");
        }
    }
}
