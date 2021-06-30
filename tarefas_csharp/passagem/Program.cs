using System;

namespace passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            string resp = "0";
            string rrr ="";
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] dest = new string[5];
            int[] dia = new int[5];
            int[] mes = new int[5];
            int contador = 0;

            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Insira sua senha para efetuar o login: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                senha = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if(senha == 123456)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Senha correta!");
                    Console.WriteLine("");

                } else if(senha != 123456)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("");

                }
            }while(senha != 123456);

            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("[1] - Cadastro das passagens");
                Console.WriteLine("[2] - Lista das passagens");
                Console.WriteLine("[0] - Sair");
                resp = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                switch(resp){

                    case "1":

                    do{
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Nome do {1+contador}º passageiro: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        nome[contador] = Console.ReadLine();

                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Origem do {1+contador}º passageiro: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        origem[contador] = Console.ReadLine();

                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Destino do {1+contador}º passageiro: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        dest[contador] = Console.ReadLine();

                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"dia do voo do {1+contador}º passageiro: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        dia[contador] = int.Parse(Console.ReadLine());

                        Console.WriteLine("");                       

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"mes do voo do {1+contador}º passageiro: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        mes[contador] = int.Parse(Console.ReadLine());

                        contador++;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Deseja cadastrar mais alguem? (s/n)");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        rrr = Console.ReadLine();

                    } while( rrr == "s");

                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cadastro bem sucedido!!");

                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Deseja voltar para o menu? (1{s}/0{n})");
                    resp = Console.ReadLine();

                    if(resp == "0")
                    {   
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Obrigado por coperar conosco");
                    }

                    break;

                    case "2":

                    for( var i = 0; i < contador; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Passageiro: {nome[i]} ");
                        Console.Write($"origem: {origem[i]} ");
                        Console.Write($"destino: {dest[i]} ");
                        Console.Write($"dia: {dia[i]} ");
                        Console.Write($"mes: {mes[i]} ");


                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("");
                    }

                    Console.WriteLine("Deseja voltar para o menu? (1{s}/0{n})");
                    resp = Console.ReadLine();
                     if(resp == "n")
                    {
                         Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Obrigado por coperar conosco");
                    }

                    break;

                    case "0":
                     Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Obrigado por coperar conosco");
                    
                    break;
                }
                    
            }while( resp =="1");

         }
     }
 }

