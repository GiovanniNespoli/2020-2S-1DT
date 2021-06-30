using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa info = new Pessoa();

            Console.WriteLine("Insira o seu nome: ");
            info.nome = Console.ReadLine();

             Console.WriteLine("");

            Console.WriteLine("Insira o seu sobrenome: ");
            info.sobrenome = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            string rr = "";
        do{

            Console.WriteLine("Você é uma pessoa física ou jurídica??");
            string resp = Console.ReadLine();

            fisica fis = new fisica();
            juri jur = new juri();
            
            jur
             if( resp == "física")
             {
                 Console.WriteLine("");

                 Console.WriteLine("Insira o seu CPF: ");
                 fis.cpf = Console.ReadLine();

                 Console.WriteLine("");

                 Console.WriteLine("Insira o RG: ");
                 fis.rg = Console.ReadLine();

                 if(fis.ValidarCPF(fis.cpf) == false || fis.ValidarRG(fis.rg) == false)
                 {
                     Console.WriteLine("ops, alguma informção está errada");
                     Console.WriteLine("");
                     rr = "y";
                 } else if (fis.ValidarCPF(fis.cpf) == true || fis.ValidarRG(fis.rg) == true )
                 {
                     rr = "n";
                 }

             } else if( resp == "jurídica"){
                 Console.WriteLine("");

                 Console.WriteLine("Insira o seu CNPJ: ");
                 jur.cnpj = Console.ReadLine();

                 Console.WriteLine("");

                 Console.WriteLine("Insira a sua Inscrição estadual: ");
                 jur.inscricao = Console.ReadLine();

                 if(jur.ValidarCnpj(jur.cnpj) == false){
                    Console.WriteLine("Insira um CNPJ válido");
                    Console.WriteLine("");
                    rr = "y";
                    } else if (jur.ValidarCnpj(jur.cnpj) == true){
                        rr = "n";
                    }
             }
        }while(rr == "y");

              Console.WriteLine("");

            Console.WriteLine("Válidação concluída");

             Console.WriteLine("");       

             Console.WriteLine(info.BoasVindas(info.nome, info.sobrenome));


        }
    }
}
