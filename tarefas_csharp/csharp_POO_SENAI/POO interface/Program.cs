using System;
using POO_interface.classe;

namespace POO_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string rr = "";
            string alt = "";
            string delet = "";

            Carrinho car = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "pc gamer";
            p1.Preco = 5000;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "Xbox";
            p2.Preco = 4000;
            
            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "Play Station";
            p3.Preco = 4000;
            
            car.produtos(p1, p2, p3);
        do{

            Console.WriteLine("Insira o código que você queira por em sua lista: ");
            int resp = int.Parse(Console.ReadLine());

            if(resp == 1)
            {
                car.Cadastrar(p1);
            }
            else if(resp == 2)
            {
                car.Cadastrar(p2);
            }
            else if(resp == 3)
            {
                car.Cadastrar(p3);
            }
            else
            {
                Console.WriteLine("Insira uma resposta válida");
            }

            Console.WriteLine("Deseja inserir mais algum? (s/n)");
            rr = Console.ReadLine();

        }while(rr == "s");

        Console.WriteLine("");

        Console.WriteLine("Codigo inserido com sucesso");
        car.Listar();
        car.precoTotal();

        Console.WriteLine("");
    do{

        Console.WriteLine("Deseja deletar algum item? (s/n)");
        delet = Console.ReadLine();

        if(delet == "s")
        {
            car.Listar();
            car.precoTotal();
            Console.WriteLine("Insira o codigo que do produto que queira deletar");
            int cod = int.Parse(Console.ReadLine());

            car.delete(cod);
            car.Listar();
            car.precoTotal();
        }
    }while(delet == "s");

    do{

        Console.WriteLine("Deseja mudar o codigo de um do seus itens? (s/n)");
        alt = Console.ReadLine();

        if( alt == "s")
        {
            Console.WriteLine("Insira o código a ser alterado: ");
            int codi = int.Parse(Console.ReadLine());

            car.Alterar(codi, p3);
            Console.WriteLine("");

            car.Listar();
            car.precoTotal();
        }
    }while(alt == "s");

        Console.WriteLine("Boa");

        }
    }
}
