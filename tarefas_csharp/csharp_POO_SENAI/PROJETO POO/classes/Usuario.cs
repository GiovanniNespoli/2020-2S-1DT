using System;

namespace PROJETO_POO.classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string  Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        public Usuario()
            {
                Cadastrar();
            }

        public Usuario(string name, string mail, string pass)
        {
            name = Nome;
            mail = Email;
            pass = Senha;
        }
        
        public void Cadastrar()
        {
            Nome = "Giovanni";
            Email = "ggnespoli@gmail.com";
            Senha = "123pin567";
            DataCadastro = DateTime.UtcNow;
        }
        public void Deletar()
        {
            Nome = "";
            Email = "";
            Senha = "";
        }
        
    }
}