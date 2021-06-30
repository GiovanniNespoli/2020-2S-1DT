namespace POO_Heranca.classes
{
    public class fisica : Pessoa
    {
        public string cpf;

        public string rg;

        public bool ValidarCPF(string doc){
            if(doc == "" || doc == "000.000.000-00"){
                return false;
            }
            return true;
        }

        public bool ValidarRG( string doc){
            if(doc == "" || doc == "0000000000000"){
                return false;
            }
            return true;
        }
    }
}