using System.Collections.Generic;
using System.IO;
using Interfaces;

namespace Eplayers_AspnetCore.Models
{
    public class Jogador : EPlayersBase , IJogador
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public int IdEquipe { get; set; }
        // Login
        public string Email { get; set; }
        public string Senha { get; set; }
        private const string PATH = "DataBase/Jogador.csv";

        public Jogador()
        {
            CreateFolderAndFile(PATH);
        }

        public string apoio(Jogador x)
        {
            return $"{x.IdJogador}{x.Nome}{x.IdEquipe};{x.Email};{x.Senha}";
        }
        public void Create(Jogador x)
        {
            string[] linha = { apoio(x) };
            File.AppendAllLines(PATH , linha);
        }

        public void Delete(int x)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            // 1;FLA;fla.png
            linhas.RemoveAll(x => x.Split(";")[0] == IdJogador.ToString());                        
            RewriteCSV(PATH, linhas);
        }

        public List<Jogador> ReadAll()
        {
            List<Jogador> jogadores = new List<Jogador>();
            string[] ler = File.ReadAllLines(PATH);

            foreach(var item in ler)
            {
                string[] linha = item.Split(';');
                Jogador jg = new Jogador();

                jg.IdJogador = int.Parse( linha[0] );
                jg.Nome = linha[1];
                jg.IdEquipe = int.Parse( linha[2] );
                jg.Email = linha[3];
                jg.Senha = linha[4];

                jogadores.Add(jg);
            }

            return jogadores;
        }

        public void Update(Jogador e)
        {
             List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(y => y.Split(";")[0] == e.IdJogador.ToString());
            linhas.Add( apoio(e) );                        
            RewriteCSV(PATH, linhas); 
        }
    }
}