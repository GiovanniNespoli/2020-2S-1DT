using System;
using POO_Polimorfismo_2.classes;

namespace POO_Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionario funci = new funcionario();
            int a = 0;
            int b = 0;

                Console.WriteLine("Deseja ver os nomes na lista?? (s/n)");
                string resp = Console.ReadLine();

                Console.WriteLine("");

                if(resp == "s")
                {
                    funci.Mostrar();
                } else
                {
                    Console.WriteLine("ok");
                }
        do{

                Console.WriteLine("Deseja pesquisar o nome por indice[a] ou por busca[b] ??");
                string rr = Console.ReadLine();

                Console.WriteLine("");
            do{

                switch(rr)
                {
                    case "a":
                    Console.Write("Digite um numero entre 0 a 2 = ");
                    int dig = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    if(dig > 2 || dig < 0)
                    {
                        Console.WriteLine("Selecione um numero válido bb");
                        a = 1;
                        b = 2;
                    } else if ( dig >= 0 && dig <= 2)
                    {
                        Console.Write("Resultado da busca = ");
                        funci.Mostrar(dig);
                        a = 2;
                        b = 2;
                    }
                    break;

                    case "b":
                    Console.Write("Insira a busca = ");
                    string busca = Console.ReadLine();

                    funci.Mostrar(busca);
                    a = 2;
                    b = 2;

                    break;

                    default:
                    Console.WriteLine("Insira uma resposta válida animal");
                    b = 1;

                    break;

                }
            }while( a == 1);
         }while(b == 1);
        }       
    }
}
