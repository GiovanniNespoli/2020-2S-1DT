namespace POO_abstracao.classe
{
    public class debito : cartao
    {
        private float saldo = 600;
        public float Saldo{
            get{ return saldo;}
        }

        public void pagar(string x){
             if(x == "s")
            {
                System.Console.WriteLine("Compra bem sucedida");
            } else{
                System.Console.WriteLine("Encerrando a compra");
            }
        }
        
    }
}