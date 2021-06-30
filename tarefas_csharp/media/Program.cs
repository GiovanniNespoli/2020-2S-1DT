using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a 1º nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            

            Console.Write("Insira a 2º nota: ");
            double nota2 = double.Parse(Console.ReadLine());


            double media = (nota1 + nota2) / 2;

            string situation = "";

           if(media > 7) {
               situation = "Aprovado";
           } else {
               situation = "Reprovado";
           }

           Console.Write(situation);
           Console.Write(", com a média de: ");
           Console.WriteLine(media);
        }
    }
}
