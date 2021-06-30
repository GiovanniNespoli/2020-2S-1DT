namespace lista_de_objeto.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }


        public Produto()
        {

        }
        
        public Produto(int cod, string nom, float prec)
        {
            Codigo = cod;
            Nome = nom;
            Preco = prec;
        } 
        
        
    }
}