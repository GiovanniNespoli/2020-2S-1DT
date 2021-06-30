using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double sal;
            string civil;
            string cases = "";
do{
            Console.WriteLine("Bem vindo a tela de cadastro");

            Console.WriteLine("");

            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Insira sua idade:");
            idade = int.Parse(Console.ReadLine());

                                    


            while(idade < 0 || idade > 150){
                Console.WriteLine("Idade inválida");
                Console.WriteLine("");
                Console.WriteLine("Insira uma idade válida:");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Insira o seu salário:");
            sal = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            while( sal <=0)
            {
                Console.WriteLine("Salário inválido");
                Console.WriteLine("");
                Console.WriteLine("Insira um salário válido:");
                sal = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Seu estado civil: ( [s]solteiro(a) / [c]casado(a) / [v]viuvo(a) / [d]divorciado(a) )");
            civil = Console.ReadLine();
                
                switch(civil){

                case "s":
                Console.WriteLine("Cadastro feito com sucesso");
                break;

                 case "c":
                Console.WriteLine("Cadastro feito com sucesso");
                break;

                 case "v":
                Console.WriteLine("Cadastro feito com sucesso");
                break;

                 case "d":
                Console.WriteLine("Cadastro feito com sucesso");
                break;

                default:
                Console.WriteLine("Selecione uma resposta válida");
                Console.WriteLine("");
                Console.WriteLine("deseja recomeçar seu cadastro? (y/n)");
                cases = Console.ReadLine();
                break;
               }
}while(cases == "y");
         }
     }
  }
