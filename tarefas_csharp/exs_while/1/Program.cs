using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecione uma nota de 0 a 10: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while(nota >10 || nota<0){
                Console.WriteLine("Porfavor, insira um valor válido");
                Console.WriteLine("");
                Console.Write("Selecione uma nota de 0 a 10: ");
                Console.WriteLine("");
                nota = int.Parse(Console.ReadLine());
            }
            if(nota>0 || nota<10){

               Console.WriteLine("Obrigado por inserir a nota certa");
            }
        }
    }
}
