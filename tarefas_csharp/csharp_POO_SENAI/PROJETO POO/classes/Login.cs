using System;

namespace PROJETO_POO.classes
{
    public class Login
    {
        public bool LoginUsuario {get; set;}

        public Login()
        {
            Logar();

            if(LoginUsuario == true)
            {
                GerenciarMenu();
            }
        }

        public void GerenciarMenu()
        {
            string resp = "";
            int x = 0;
            Marca marca = new Marca();
            Produtos produto = new Produtos();

            do{

                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("[1] - Cadastrar marca");
                Console.WriteLine("[2] - Listar marca");
                Console.WriteLine("[3] - Excluir marca");
                Console.WriteLine("[4] - Cadastrar produto");
                Console.WriteLine("[5] - Listar produto");
                Console.WriteLine("[6] - Excluir produto");
                Console.WriteLine("[0] - Sair");
                Console.ResetColor();
                resp = Console.ReadLine();


                switch(resp)
                {
                    case "1":
                    marca.cadastrar();
                    resp = "s";
                    break;

                    case "2":
                    marca.ListarMarcas();
                    resp = "s";
                    break;

                    case "3":
                    marca.DeletarMarca(x);
                    resp = "s";
                    break;

                    case "4":
                    produto.Cadastrar();
                    resp = "s";
                    break;

                    case "5":
                    produto.listar();
                    resp = "s";
                    break;

                    case "6":
                    produto.Deletar(x);
                    resp = "s";
                    break;

                    case "0":
                    Console.WriteLine("Tchau");
                    resp = "n";
                    break;

                    default:
                    Console.WriteLine("Selecione uma opção válida");
                    resp = "s";
                    break;

                }

            }while(resp == "s");
        }
        
        public void Logar()
        {
        
        do{

            Usuario user = new Usuario();

            Console.WriteLine("Email para o login: ");
            string mail = Console.ReadLine();

            Console.WriteLine("Senha para o login: ");
            string pass = Console.ReadLine();
            
            if(mail == user.Email && pass == user.Senha)
            {
                LoginUsuario = true;
                Console.WriteLine("Login feito com sucesso");
            }
            else
            {
                Console.WriteLine("Falha no login");
                LoginUsuario = false;
            }
        }while(LoginUsuario == false);
        }

        public void Deslogado()
        {
            LoginUsuario = false;
        }
    }
}