using System;

namespace _2
{
    public class jogador
    {
        private string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        private string posicao;
        public string Posicao{
            get{ return posicao;}
            set{ posicao = value;}
        }
        private int anoDeNas;
        public int AnoDeNas{
            get{ return anoDeNas;}
            set{ anoDeNas = value;}
        }
        private string nacionalidade;
        public string Nacionalidade{
            get{ return nacionalidade;}
            set{ nacionalidade = value;}
        }
        private int altura;
        public int Altura{
            get{return altura;}
            set{altura = value;}
            }
        private int peso;
        public int Peso{
            get{ return peso;}
            set{ peso = value;}
        }


        // Metodos

        public int id(int idade)
        {
           int final = 2020 - idade;
           return final; 
        }

        public void info()
        {
            Console.WriteLine(this.nome);

            Console.WriteLine(this.posicao);

            Console.WriteLine($"{id(this.anoDeNas)} anos");

            Console.WriteLine(this.nacionalidade);

            Console.WriteLine($"{this.altura} cm");

            Console.WriteLine($"{this.peso} kg");
        }

        public void apo(string pos)
        {
            if(pos == "atacante")
            {
                Console.WriteLine($"Voce se aposentara em {35 - id(this.anoDeNas)} anos");  
            } 
            else if(pos == "meio-campo")
            {
                Console.WriteLine($"Voce se aposentara em {38 - id(this.anoDeNas)} anos");
            }
            else if( pos == "defesa")
            {
                Console.WriteLine($"Voce se aposentara em {40 - id(this.anoDeNas)} anos");
            }
            else if( pos == "goleiro")
            {
                Console.WriteLine($"Voce se aposentara em {45 - id(this.anoDeNas)} anos");
            }
        }
        

    }
}