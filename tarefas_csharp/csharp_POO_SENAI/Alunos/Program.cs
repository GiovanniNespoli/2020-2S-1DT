using System;
using Cadastro.Classes;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno cadastrar = new aluno();

            Console.Write("Digite o nome do aluno: ");
            cadastrar.nomeCompleto = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Insira o nome do curso: ");
            cadastrar.curso = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Idade do aluno: ");
            cadastrar.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Insira o RG do aluno: ");
            cadastrar.rg = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("=================================================");
            Console.WriteLine("");

            Console.Write("O aluno é bolsista? (s|n)");
            string resp = Console.ReadLine();

            if(resp.ToLower() == "s")
            {
                cadastrar.bolsista = true;
            } else
            {
                cadastrar.bolsista = false;
            }

            Console.Write("Insira a média do aluno: ");
            cadastrar.media = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor da mensalidade: ");
            cadastrar.mensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("=================================================");
            Console.WriteLine("");

            cadastrar.VerMediaFinal(cadastrar.media);
            cadastrar.VerMensalidade(cadastrar.bolsista, cadastrar.mensalidade);
        }
    }
}
