namespace POO_Heranca.classes
{
    public class juri : Pessoa 
    {
        public string cnpj;

        public string inscricao;

        public bool ValidarCnpj(string docu){
            if(docu != ""){
                return true;
            }
            return false;
        }
    }
}