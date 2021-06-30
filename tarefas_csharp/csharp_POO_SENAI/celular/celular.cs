using System;

namespace celular
{
    public class celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool on;

        public void ligado(bool on)
        {
            if(on == true){
                Console.WriteLine("ligando");
            } else if( on == false){
                Console.WriteLine("OK, tchau");
            }

        }

        public void vdd(bool on = true)
        {
            Console.WriteLine("Bem vindo");
            bool a;
            do{
                Console.WriteLine("O que deseja fazer?");

                Console.WriteLine("");

                Console.WriteLine("ligação [1]");
                Console.WriteLine("Mensagem [2]");
                Console.WriteLine("Desligar [3]");
                string r = Console.ReadLine();

                Console.WriteLine("==========================================");

                Console.WriteLine("");

                switch(r)
                {
                    case "1":
                    Console.WriteLine("Fazendo ligação...");
                    
                    Console.WriteLine("");

                    Console.WriteLine("Não atendida...");

                    Console.WriteLine("==========================================");

                    a = true;
                    break;

                    case "2":
                    Console.WriteLine("uaitsap: ");
                    Console.ReadLine();

                    Console.WriteLine("");

                    Console.WriteLine("Mensagem enviada com sucesso");

                    Console.WriteLine("==========================================");

                    a = true;
                    break;

                    case "3":
                    Console.WriteLine("Ok, tchau");
                    a = false;
                    break;

                    default:
                    Console.WriteLine("Por favor, selecione uma opção válida");

                    Console.WriteLine("==========================================");
                    
                    a = true;
                    break;
                }
            }while(a == true);
        }
    }
}