namespace POO_abstracao.classe
{
    public class credito : cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
        }

        public void pagarCredito(string x){
            if(x == "s")
            {
                System.Console.WriteLine("Compra bem sucedida");
            } else{
                System.Console.WriteLine("Encerrando a compra");
            }
        }


    }
}