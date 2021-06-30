namespace POO_Heranca.classes
{
    public class Pessoa
    {
        public string nome;

        public string sobrenome;

        public string BoasVindas(string nomeUsuario, string sobrenomeUsuario){
            return "Olá, Bem vindo "+nomeUsuario + " " + sobrenomeUsuario;
        }
    }
}