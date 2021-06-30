namespace POO_encapsulamento.classes
{
    public class Cartao
    {
        private string numero;
        private string nome;
        public string Nome{get; set;}
        private string bandeira;
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
            }
        private string cvv;
        public string CVV{get;set;}
        protected float limite = 5000;
        public float Limite{
            get{return limite;}
        }

        }
    }
