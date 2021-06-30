namespace metodos_construtores.classe
{
    public class produto
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Desc{ get; set;}
        public int Estoque{get; set;}

        // metodos construtores

        public produto()
        {

        }
        public produto(int cod, int est)
        {
            Codigo = cod;
            Estoque = est;
        }
        public produto(int cod, string nom, string desc, int est)
        {
            Codigo = cod;
            Nome = nom;
            Desc = desc;
            Estoque = est;            
        }
    }
}