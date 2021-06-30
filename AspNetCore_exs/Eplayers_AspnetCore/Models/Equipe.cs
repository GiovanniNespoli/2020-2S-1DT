using System;
using System.Collections.Generic;
using System.IO;
using Eplayers_AspnetCore.Interfaces;

namespace Eplayers_AspnetCore.Models
{
    public class Equipe : EPlayersBase , IEquipe
    {
        public int IdEquipe { get; set; }
        public string NomeDaEquipe { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "DataBase/Equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }        

        public string Prepare(Equipe x)
        {
            return $"{x.IdEquipe};{x.NomeDaEquipe};{x.Imagem}";
        }
        public void Create(Equipe x)
        {
            string[] linhas = { Prepare(x) };
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(';')[0] == id.ToString());

            RewriteCSV(PATH , linhas);
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> eq = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                Equipe e = new Equipe();
                string[] lin = item.Split(';');

                e.IdEquipe = Int32.Parse( lin[0] );
                e.NomeDaEquipe = lin[1];
                e.Imagem = lin[2];

                eq.Add(e);
            }

            return eq;
        }

        public void uptade(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(';')[0] == e.IdEquipe.ToString());

            linhas.Add( Prepare(e) );
            RewriteCSV(PATH , linhas);
        }

    }
}