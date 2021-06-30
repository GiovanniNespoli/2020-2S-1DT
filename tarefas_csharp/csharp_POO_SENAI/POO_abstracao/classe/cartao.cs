namespace POO_abstracao.classe
{
    public abstract class cartao    
    {
        private string bandeira;
        public string Bandeira{
            get{ return bandeira;}
            set{ bandeira = value;}
        }
        private string numero;
        public string Numero{
            get{ return numero;}
            set{ numero = value;}
        }
        private string titular;
        public string Titular{
            get{ return titular;}
            set{ titular = value;}
        }
        private string cvv;
        public string CVV{
            get{ return cvv;}
            set{ cvv = value;}
        }

        public string salvarCartão(){
            return "";
        }
        
    }
}