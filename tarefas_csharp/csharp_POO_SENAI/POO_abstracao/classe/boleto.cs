namespace POO_Abstracao.classe
{
    public class boleto : pagamento
    {
        private string codigoDeBarras = "123456789";

        public void registrar(){
            System.Console.WriteLine($"O codigo de barras é: {this.codigoDeBarras}");
        }

    }
}