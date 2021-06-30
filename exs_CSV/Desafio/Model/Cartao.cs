using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class Cartao
    {
        public Cartao(string nome, float numeroDoCartao, int cVV, int quatroDig) 
        {
            this.Nome = nome;
    this.NumeroDoCartao = numeroDoCartao;
    this.CVV = cVV;
    this.quatroDig = quatroDig;
   
        }
                public string Nome { get; set; }
        public float NumeroDoCartao { get; set; }
        public int CVV { get; set; }
        public int quatroDig { get; set; }

        private const string PATH = "DataBase/Cartao.csv";

        public Cartao()
        {
        string linha = PATH.Split('/')[0];

        if(!Directory.Exists(PATH))
        {
            Directory.CreateDirectory(linha);
        }
        if(!File.Exists(PATH))
        {
            File.Create(PATH);
        }

        }
        
        public string est( Cartao x)
        {
            return $"{x.Nome};{x.NumeroDoCartao};{x.CVV};{x.quatroDig};";
        }

        public void inserir(Cartao y)
        {
            string[] linha = { est(y) };

            File.AppendAllLines(PATH, linha);
        }

        public List<Cartao> ler()
        {
            List<Cartao> car = new List<Cartao>();

            string[] ler = File.ReadAllLines(PATH);

            foreach(var x in ler)
            {
                string[] sep = x.Split(';');

                Cartao cartao = new Cartao();
                cartao.Nome = sep[0];
                cartao.NumeroDoCartao = float.Parse( sep[1] );
                cartao.CVV = int.Parse( sep[2] );
                cartao.quatroDig = int.Parse( sep[3]);

                car.Add(cartao);
            }

            return car;
        }
    }
}