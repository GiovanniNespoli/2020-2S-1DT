using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salário que você recebe da empresa: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            double regra = salario * 30;
            double regra2 = regra / 100;
            double rejuste = regra2 + salario;
            
            if(salario < 500){
                Console.Write("Seu novo salário será: ");
                Console.Write(rejuste);
                Console.WriteLine(" reais");
            } else{
                Console.WriteLine("O reajuste não foi dado a pessoas com salário maior de 500R$");
            }
        }
    }
}
