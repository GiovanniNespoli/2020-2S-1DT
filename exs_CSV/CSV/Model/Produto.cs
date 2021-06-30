using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public float Preco { get; set; }

        // banco de dados
        private const string PATH = "DataBase/Produto.csv";

        // metodo contrutor para criar o banco de dados
        public Produto()
        {
            // var para separar e criar a pasta e o file
            string banco = PATH.Split('/')[0];

            if(!Directory.Exists(banco))
            {
                Directory.CreateDirectory(banco);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Read()
        {
            // Lista para armazenar o csv
            List<Produto> produtos = new List<Produto>();

            // lendo as linhas
            string[] linhas = File.ReadAllLines(PATH);
            
            // Adicionando a lista
            foreach( string lista in linhas)
            {
                // Separando as linhas
                string[] sep = lista.Split(';');

                // instanciamos para produtos para dps passar para a List produtos

                Produto prod = new Produto();
                prod.Nome = sep[0];
                prod.Codigo = int.Parse( sep[1] );
                prod.Preco = float.Parse( sep[2] );

                produtos.Add(prod);

            }

            return produtos;
        }

        // vamos criar como será escrito e passar nossa classe Produto para string

        public string linha(Produto x)
        {
            return $"{x.Nome};{x.Codigo};{x.Preco};";
        }

        // agr vms inserir as linhas

        public void inserir(Produto p)
        {
            string[] linhas = { linha(p) };

            File.AppendAllLines(PATH, linhas );
        }

    }
}