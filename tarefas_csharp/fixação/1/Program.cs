using System;

namespace fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento: ");
            int idade = int.Parse(Console.ReadLine());

            int media( int idade)
            {
                int voto = 2020 - idade;

                return voto;
            }

            if( media(idade) >= 16)
            {
                Console.WriteLine($"Você já pode votar");
            }
             else if ( media(idade) <= 15)
            {
                Console.WriteLine($"Você ainda não tem a idade apropriada para votar");
            }
        }
    }
}
