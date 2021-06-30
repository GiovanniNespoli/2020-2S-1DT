using System;

namespace Cadastro.Classes
{
    public class aluno
    {
        public string nomeCompleto;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float media;
        public double mensalidade;

        public void VerMediaFinal(float media)
        {
            Console.WriteLine($"A média do aulno é:{media}");
        }

        public void VerMensalidade(bool bolsista, double mensalidade)
        {
            if(bolsista == true)
            {
                Console.WriteLine("Este aluno é bolsista");
                Console.WriteLine($"Mesalidade sem desconto: {mensalidade}");
                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");
                
            } else {
                Console.WriteLine("Este aluno não é bolsista");
                Console.WriteLine($"Mesalidade : {mensalidade}");
            }
        }

    }
}