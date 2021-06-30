using System;
using POO_abstracao.classe;
using POO_Abstracao.classe;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            string rrr = "";
            float arm = 0;
            float arme = 0;
            float armee = 0;
            float total = 0;
            float jurosTotal = 0;
        
        do{
            Console.WriteLine("Selecione o Produto: ");

            Console.WriteLine("");

            Console.WriteLine("Teclado gamer led RGB - Red Dragon [1000,00 R$] (a)");
            Console.WriteLine("Mouse gamer 10000 de DPI led RGB - Red Dragon [1500,00 R$] (b)");
            Console.WriteLine("Mouse simples 400 de DPI - multilaiser [100,00 R$] (c)");
            resp = Console.ReadLine();

            Console.WriteLine("");

            if(resp == "a")
            {
                Console.WriteLine("Quantos deseja levar?");
                int quantos = int.Parse(Console.ReadLine());

                int preço(int quantos){
                 return  quantos * 1000;
                }

                Console.WriteLine("");

                arm = preço(quantos);

            } else if(resp == "b")
            {
                 Console.WriteLine("Quantos deseja levar?");
                int quantos = int.Parse(Console.ReadLine());

                int preço(int quantos){
                 return  quantos * 1500;
                }

                Console.WriteLine("");

                arme = preço(quantos);

            } else if( resp == "c")
            {
                 Console.WriteLine("Quantos deseja levar?");
                int quantos = int.Parse(Console.ReadLine());

                int preço(int quantos){
                 return  quantos * 100;
                }

                Console.WriteLine("");

                armee = preço(quantos);

            }
                total = arm + arme + armee;

                Console.WriteLine($"O total será de {total},00 R$");

                Console.WriteLine("Deseja comprar mais? (s/n)");
                resp = Console.ReadLine();

        }while(resp == "s");

        Console.WriteLine("");

        boleto bol = new boleto();

        Console.WriteLine("Qual será a forma de pagamento? (boleto = a/ Cartão = b)");
        string rr = Console.ReadLine();

        Console.WriteLine("");
         
         if(rr == "a")
         {
             Console.Write("O sistema de pagamento escolhido foi o de boleto");

             double desc(float valor)
             {
                 return valor * 0.88;
             }

             Console.WriteLine("");

             Console.WriteLine("Como o pagamento é por boleto, voce ganhará 12% de desconto");
             Console.WriteLine($"O total agora será de {desc(total)},00 R$");
             Console.WriteLine($"Hora da compra: {bol.Data}");

             bol.registrar();
         } else
         {
         
         credito cre = new credito();
         debito deb = new debito();

         Console.Write("O sistema de pagamento escolhido foi o de Cartão ");

         Console.WriteLine("Porém não há em nosso site nenhum cadastro do seu cartão, faça agora");
        
         Console.WriteLine("");

         Console.WriteLine("Insira a Bandeira do cartão: ");
         cre.Bandeira = Console.ReadLine();

         Console.WriteLine("");

         Console.WriteLine("Insira os números do cartão: ");
         cre.Numero = Console.ReadLine();

         Console.WriteLine("");

         Console.WriteLine("Titular do cartão: ");
         cre.Titular = Console.ReadLine();

         Console.WriteLine("");

         Console.WriteLine("Insira o CVV do cartão: ");
         cre.CVV = Console.ReadLine();

         Console.WriteLine("");

         Console.WriteLine("Cadastro feito bem com sucesso");

         Console.WriteLine("");

         Console.WriteLine("Qual será a forma de pagamento, credito(a) ou debito(b)");
         string forma = Console.ReadLine();


         if(forma == "a")
         {

            Console.WriteLine("Insira as informções que foram cadastardas");

            Console.WriteLine("");

            Console.WriteLine("Bandeira do cartão:");
            string band = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Numero do cartão: ");
            string num = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Titular: ");
            string tit = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Fazendo uma confirmaçaõ");

            Console.WriteLine("");


            if(band != cre.Bandeira)
            {
                Console.WriteLine("Alguma credencial esta errada");
                Console.WriteLine("Encerrando compra");
            } else if( num != cre.Numero)
            {
                 Console.WriteLine("Alguma credencial esta errada");
                 Console.WriteLine("Encerrando compra");
            } else if( tit != cre.Titular)
            {
                 Console.WriteLine("Alguma credencial esta errada");
                 Console.WriteLine("Encerrando compra");
            }else{

            Console.WriteLine("Confirmação bem sucedida");
            }
    

            Console.WriteLine("");

            Console.WriteLine("Deseja parcelar? (s/n)");
            string par = Console.ReadLine();

            Console.WriteLine("");

            do{

            if(par == "s")
            {
                Console.WriteLine("Em quantas vezes?");
                int vez = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if(vez <= 6)
                {
                    Console.WriteLine("Juros consebido de 5%");

                    float juros(float valor)
                    {
                        float cem = valor * 5;
                        float cemm = cem / 100;
                        float total = cemm + valor; 

                        return total;
                    }

                    jurosTotal = juros(total);

                    rrr = "n";

                } else if ( vez > 6 && vez <= 12)
                {
                    Console.WriteLine("Juros concebido de 8%");

                     float juros(float valor)
                    {
                        float cem = valor * 8;
                        float cemm = cem / 100;
                        float total = cemm + valor;

                        return total;
                    }

                    jurosTotal = juros(total);

                    rrr = "n";

                } else if( vez > 12)
                {
                    Console.WriteLine("Não é permitido parcelas maiores do que 12 vezes");
                    rrr = "repeate";
                }
            }

            }while(rrr == "repeate");

            Console.WriteLine("");

            if(jurosTotal >= cre.Limite)
            {
                Console.WriteLine("Limite do cartão estourado");
                Console.WriteLine("Encerrando a compra");
            } else
            {
                Console.WriteLine(cre.Bandeira);
                Console.WriteLine(cre.Numero);
                Console.WriteLine(cre.Titular);
                Console.WriteLine($"{jurosTotal},00 RS$ (valor com juros)");

                Console.WriteLine("");

                Console.WriteLine("As informações acima estão coretas? (s/n)");
                string x = Console.ReadLine();

                Console.WriteLine("");

                cre.pagarCredito(x);

                Console.WriteLine($"Hora da compra: {bol.Data}");

            }

            // boleto

         } else if( forma == "b")
         {
             Console.WriteLine("Insira as informções que foram cadastardas");

            Console.WriteLine("");

            Console.WriteLine("Bandeira do cartão:");
            string band = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Numero do cartão: ");
            string num = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Titular: ");
            string tit = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Fazendo uma confirmaçaõ");

            Console.WriteLine("");


            if(band != cre.Bandeira)
            {
                Console.WriteLine("Alguma credencial esta errada");
                Console.WriteLine("Encerrando compra");
            } else if( num != cre.Numero)
            {
                 Console.WriteLine("Alguma credencial esta errada");
                 Console.WriteLine("Encerrando compra");
            } else if( tit != cre.Titular)
            {
                 Console.WriteLine("Alguma credencial esta errada");
                 Console.WriteLine("Encerrando compra");
            }else if( total > deb.Saldo)
            {
                Console.WriteLine("Limite do saldo ultrapassado");
                Console.WriteLine("Encerrando compra");
            } else
            {
            Console.WriteLine("Confirmação bem sucedida");

            Console.WriteLine("");

            Console.WriteLine(cre.Bandeira);
            Console.WriteLine(cre.Numero);
            Console.WriteLine(cre.Titular);
            Console.WriteLine($"{total},00 RS$");

            Console.WriteLine("");

            Console.WriteLine("As informações acima estão coretas? (s/n)");
            string x = Console.ReadLine();

            Console.WriteLine("");

            deb.pagar(x);

            Console.WriteLine($"Hora da compra: {bol.Data}");
            }

         }
         
           }
        }
    }
}
