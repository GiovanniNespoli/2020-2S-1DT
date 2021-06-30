using System;
using obj_com_argumentos.classes;

namespace obj_com_argumentos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string resp = "";
            string r = "";

            Produto p1 = new Produto("p1" ,1, "GTA", 50F);
            Produto p2 = new Produto("p2",2, "FIFA", 150F);
            Produto p3 = new Produto("p3",3, "CS", 25F);
            Produto p4 = new Produto("p4",4, "R6", 80F);

            carrinho car = new carrinho();

            car.addCar(p1);
            car.addCar(p2);
            car.addCar(p3);
            car.addCar(p4);

            car.mostrarCar();
            car.valorTotal();

            Console.WriteLine("");
        do{

            Console.WriteLine("Deseja adicionar um novo produto? (s/n)");
            resp = Console.ReadLine();

            if(resp == "s")
            {
                Console.WriteLine("Lista de produtos");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PRODUTO: p5 / CODIGO: 5 / NOME: RL / PRECO: 40R$");
                Console.WriteLine("PRODUTO: p6 / CODIGO: 6 / NOME: Mine / PRECO: 60R$");
                Console.ResetColor();

                Produto p5 = new Produto("p5",5, "RL", 40F);
                Produto p6 = new Produto("p6",6, "Mine", 60F);

                 Console.WriteLine("");

                 Console.WriteLine("Insira o codigo do produto que deseja adicioanar");
                 int rr = int.Parse(Console.ReadLine());

                 if(rr == 5)
                 {
                     car.addCar(p5);
                     Console.WriteLine("Produto adicionado com sucesso");
                 } else if( rr == 6)
                 {
                     car.addCar(p6);
                     Console.WriteLine("Produto adicionado com sucesso");
                 } else
                 {
                     Console.WriteLine("insira uma resposta válida");
                 }
            } 
        } while(resp == "s");

        Console.WriteLine("");

        car.mostrarCar();
        car.valorTotal();

        Console.WriteLine("");
    do{

        Console.WriteLine("Deseja remover algum item? (s/n)");
        r = Console.ReadLine();

        Console.WriteLine("");

    
        if(r == "s")
        {
            Console.WriteLine("Insira o (p)roduto que será tirado do carrinho");

            car.mostrarCar();

            string p = Console.ReadLine();

            if(p == "p1")
            {
                car.remover(p1);
                Console.WriteLine("Produto removido com sucesso");
            }
             else if( p == "p2")
            {
                car.remover(p2);
                Console.WriteLine("Produto removido com sucesso");
            }
            else if(p == "p3")
            {
                car.remover(p3);
                Console.WriteLine("Produto removido com sucesso");
            }
            else if(p == "p4")
            {
                car.remover(p4);
                Console.WriteLine("Produto removido com sucesso");
            }
            else if(p == "p5")
            {
                Console.WriteLine("Produto adicionado, impossivel o retiro");
            }
            else if(p == "p6")
            {
                Console.WriteLine("Produto adicionado, impossivel o retiro");
            }
            else
            {
                Console.WriteLine("Insira uma resposta válida");
            }
        
        }
    }while(r == "s");

         car.mostrarCar();
         car.valorTotal();

        Console.WriteLine("");

      Console.WriteLine("Houve um erro e teremos que mudar o codigo do 1º, deseja que isso ocorra? (s/n)");
      string erro = Console.ReadLine();

      if(erro == "s")
      {
          Produto p7 = new Produto( "p7", 7, "GTA S", 25F);

          car.alterarCod(1, p7);
          car.mostrarCar();
          car.valorTotal();
      } 
      else
      {
          car.remover(p1);
          car.mostrarCar();
          car.valorTotal();
      }



        }
    }
}
