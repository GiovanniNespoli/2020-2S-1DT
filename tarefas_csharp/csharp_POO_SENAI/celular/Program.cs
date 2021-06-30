using System;

namespace celular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular tipo = new celular();
            string resp = "";
        do{
            Console.Write("Insira a cor do celular: ");
            tipo.cor = Console.ReadLine();
            
            Console.WriteLine("");

            Console.Write("Insira o modelo: ");
            tipo.modelo = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Insira o tamanho (cm): ");
            tipo.tamanho = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("As informções a baixo estão certas? (s/n)");
            
            Console.WriteLine("");

            Console.WriteLine($"A cor é: {tipo.cor}");
            Console.WriteLine($"Modelo: {tipo.modelo}");
            Console.WriteLine($"Tamanho de {tipo.tamanho} cm");

            Console.WriteLine("");

            resp = Console.ReadLine();

            Console.WriteLine("==========================================");
        }while( resp == "n");
            Console.WriteLine("");

            Console.WriteLine("Deseja liga-lo? (s/n)");
            string rr = Console.ReadLine();

            Console.WriteLine("");

            if(rr == "s")
            {
                tipo.on = true;

                tipo.ligado(tipo.on);
            
                Console.WriteLine("==========================================");

                tipo.vdd(tipo.on);
                
            } else 
            {
                tipo.on = false;

                Console.WriteLine("Ok, tchau");
            }

            
        }
    }
}
