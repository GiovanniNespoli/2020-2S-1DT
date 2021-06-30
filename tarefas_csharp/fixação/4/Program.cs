using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
         int maior=0, menor, i=0, numero=0, tl=0;

            Console.Write("Quantos números irá ter?");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.Write("1º número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            i=1;

            for(i = 2; i <= tl; i++){
                 Console.Write( i +"º número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero < menor){
                menor = numero;
                }
            if (numero > maior){
                maior = numero;
                }
            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();
         
        }
    }
}
