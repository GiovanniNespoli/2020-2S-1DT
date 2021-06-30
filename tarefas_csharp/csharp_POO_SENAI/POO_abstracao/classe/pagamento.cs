using System;

namespace POO_Abstracao.classe
{
    public  abstract class pagamento
    {
        private DateTime data;
        public DateTime Data{
            get{return data;}
        }
        protected float valor;
        public string cancelar(){

            return "";
        }
    }
}