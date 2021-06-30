using System.Collections.Generic;
using System.IO;

namespace Eplayers_AspnetCore.Models
{
    public abstract class EPlayersBase
    {
        public void CreateFolderAndFile(string path)
        {
            string folder = path.Split('/')[0];

            if(!Directory.Exists(folder))
            {
               Directory.CreateDirectory(folder);  
            }

            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public List<string> ReadAllLinesCSV(string PATH)
        {
            List<string> linhas = new List<string>();

            using(StreamReader file = new StreamReader(PATH))
            {
                string apoio;
                while((apoio = file.ReadLine()) != null )
                {
                    linhas.Add(apoio);
                }
            }

            return linhas;
        }

        public void RewriteCSV(string PATH, List<string> linhas)
        {
            using (StreamWriter output = new StreamWriter(PATH))
            {
                foreach(var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }

    }
}