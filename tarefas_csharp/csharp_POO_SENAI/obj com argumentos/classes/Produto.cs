namespace obj_com_argumentos.classes
{
    public class Produto
    {
        public int Codigo{ get; set;}
        public string Nome{ get; set;}
        public float Preço{ get; set;}
        public string P {get; set;}

    
        public Produto(string p,int cod, string nom, float prec)
        {
            P = p;
            Codigo = cod;
            Nome = nom;
            Preço = prec;
        }
    }
}